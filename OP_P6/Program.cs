using Microsoft.EntityFrameworkCore;
using OP_P6.Data;
using System;

namespace OP_P6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .AddDbContext<ApplicationDbContext>(
                    options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OP_P6;Trusted_Connection=True;MultipleActiveResultSets=true"));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                DatabaseSeed.Seed(context);
            }

            return;
            app.Run();
        }
    }
}
