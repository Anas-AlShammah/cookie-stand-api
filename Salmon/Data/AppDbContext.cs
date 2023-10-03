using Microsoft.EntityFrameworkCore;
using Salmon.Interfaces;
using Salmon.Models;

namespace Salmon.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public DbSet<Cookiestand> Cookiestands { get; set; }
        public DbSet<HourlySale> HourlySales { get; set; }

    }
}
