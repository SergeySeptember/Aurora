using Aurora.Controllers;
using Aurora.DBContext;
using Aurora.Entity;

namespace Aurora.Repository
{
    public static class ProductRepository
    {
        public static IEnumerable<Ads> GetAds()
        {
            using (AdsContext db = new())
            {
                var allAds = db.Ads.ToList();
                return allAds;
            };
        }
        public static string InsertAd(BodyData data)
        {
            string header = data.header;
            string body = data.body;

            if (!string.IsNullOrWhiteSpace(header) && !string.IsNullOrWhiteSpace(body))
            {
                header = header.Trim();
                body = body.Trim();

                using (AdsContext db = new())
                {
                    db.Ads.AddRange(new Ads { Header = header, Body = body, Date_create = DateTime.Now });
                    db.SaveChanges();
                };
                return "Success!";
            }
            return "Value must be string, not empty, not null";
        }

        public static Ads GetAdById(int id)
        {
            using (AdsContext db = new())
            {
                var adById = db.Ads.FirstOrDefault(a => a.Id == id);
                return adById;
            }
        }
    }
}
