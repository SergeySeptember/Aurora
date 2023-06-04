using Microsoft.EntityFrameworkCore;
using Aurora.Entity;

namespace Aurora.DBContext
{
    public class AdsContext : DbContext
    {
        public readonly AdsContext _dbContext;

        //public AdsContext(AdsContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=ads_base;username=admin;password=admin");
        }
        public DbSet<Ads> Ads { get; set; }

    }
}
