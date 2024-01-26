using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveBoo.Models
{
    public class Dishe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public bool Visible { get; set; }
        public float Price { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

    }
}
