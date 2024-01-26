namespace DeliveBoo.Models
{
    public class DisheOrder
    {
        public int DisheId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime Data { get; set; }
        public Dishe Dishe { get; set; }
        public Order Order { get; set; }
    }
}
