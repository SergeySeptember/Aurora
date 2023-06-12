using Aurora.Entity;
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

            string connectionString = configuration.GetConnectionString("PostgresDatabase");

            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Ads> Ads { get; set; }

    }
}
