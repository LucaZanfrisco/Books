namespace DeliveBoo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public float TotalPrice { get; set; }
    }
}
