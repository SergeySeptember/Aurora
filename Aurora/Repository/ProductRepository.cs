using Aurora.DBContext;
using Aurora.Entity;

namespace Aurora.Repository
{
    public static class ProductRepository
    {
        public static IEnumerable<Ads> GetAds()
        {
            using (AdsContext db = new AdsContext())
            {
                var allAds = db.Ads.ToList();
                return allAds;
            };
        }
        public static string InsertAd(string Header, string Body)
        {
            if (!string.IsNullOrWhiteSpace(Header) && !string.IsNullOrWhiteSpace(Body))
            {
                Header = Header.Trim();
                Body = Body.Trim();

                using (AdsContext db = new AdsContext())
                {
                    db.Ads.AddRange(new Ads { Header = Header, Body = Body, Date_create = DateTime.Now });
                    db.SaveChanges();
                };
                return "Success!";
            }

            return "Emty or Null";
        }
    }
}
