using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class appUser
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public InfoDescription? InfoUser { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
