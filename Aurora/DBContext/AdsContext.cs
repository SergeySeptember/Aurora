using Aurora.Entity;
using Aurora.Env;
using Microsoft.EntityFrameworkCore;

namespace Aurora.DBContext
{
    public class AdsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = DotEnv.LoadSettings();

            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Ads> Ads { get; set; }

    }
}
