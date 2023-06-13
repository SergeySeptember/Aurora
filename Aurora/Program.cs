using Aurora.DBContext;

namespace Aurora
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (AdsContext db = new())
            {
                db.Database.EnsureCreated();
            }

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}