using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class InfoDescription
    {
        [Key]
        public int Id { get; set; }
        public string Floor { get; set; }
        public string Price { get; set; }
    }
}
