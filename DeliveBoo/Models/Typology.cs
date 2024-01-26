namespace DeliveBoo.Models
{
    public class Typology
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Restaurant> Restaurants { get; set; }
    }
}
