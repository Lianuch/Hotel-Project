using Hotel.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [ForeignKey("InfoUser")]
        public int InfoUserId { get; set; }
        public InfoDescription InfoUser { get; set; }
        public RestaurantCategory RestaurantCategory { get; set; }
        [ForeignKey("appUser")]
        public string? appUserId { get; set; }
        public appUser? appUser { get; set; }
    }
}
