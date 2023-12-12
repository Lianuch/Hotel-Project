using Hotel.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set;}
        public string Description { get; set;}
        public string Image { get; set; }
        [ForeignKey("InfoUser")]
        public int InfoUserId { get; set; }
        public InfoDescription InfoUser { get; set; }
        public RoomCategory RoomCategory { get; set; }
        [ForeignKey("appUser")]
        public string? appUserId { get; set; }
        public appUser? appUser { get; set; }

    }
}
