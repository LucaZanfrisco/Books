using DeliveBoo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeliveBoo.DB
{
    public class Db : IdentityDbContext<IdentityUser>
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dishe> Dishes { get; set; }
        public DbSet<Typology> Typologies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DeliveBoo;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
