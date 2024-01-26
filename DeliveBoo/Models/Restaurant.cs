using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveBoo.Models
{
    [Table("Restaurant")]
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PIva { get; set; }
        public string Photo { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public List<Dishe> Dishes { get; set; }
        public List<Typology> Typologies { get; set; }

    }
}
