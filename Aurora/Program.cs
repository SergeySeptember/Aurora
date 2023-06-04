using Aurora.DBContext;
using Aurora.Entity;

namespace Aurora
{
    public class Program
    {
        public static void Main(string[] args)
        {






            //using (AdsContext db = new AdsContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();

            //    var ads1 = new Ads
            //    {
            //        Header = "Как же я заебался",
            //        Body = "working?",
            //        Date_create = DateTime.Now
            //    };

            //    var ads2 = new Ads
            //    {
            //        Header = "Блять",
            //        Body = "not?",
            //        Date_create = DateTime.Now
            //    };

            //    db.Ads.AddRange(ads1, ads2);
            //    db.SaveChanges();

            //}

            //Внизу не трогать!

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}