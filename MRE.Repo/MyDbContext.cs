using System;
using Microsoft.EntityFrameworkCore;

namespace MRE.Repo
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            Console.WriteLine("DbContext created");
        }
        
        public DbSet<WeatherForecast> Entities { get; set; }

        public override void Dispose()
        {
            Console.WriteLine("DbContext disposed");
            base.Dispose();
        }
    }
}
