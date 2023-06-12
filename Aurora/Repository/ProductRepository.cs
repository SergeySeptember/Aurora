using Aurora.Controllers;
using Aurora.DBContext;
using Aurora.Entity;

namespace Aurora.Repository
{
    // TODO: Add the route
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

            if (string.IsNullOrWhiteSpace(header) || string.IsNullOrWhiteSpace(body)) return "Empty or Null";
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
