using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class appUser : IdentityUser
    {
       
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public InfoDescription? InfoUser { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
