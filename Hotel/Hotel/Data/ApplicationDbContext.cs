using Hotel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Data
{
    public class ApplicationDbContext : IdentityDbContext<appUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<InfoDescription> InfoUsers { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
