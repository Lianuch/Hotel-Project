using Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<InfoDescription> InfoUsers { get; set; }
    }
}
