using artari.entities.Customers;

namespace artari.entities.Orders
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public virtual required Customer Customer { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? OrderNotes { get; set; }
        public long? TotalPrice { get; set; }
        public bool? PickupDelivery{ get; set; }
        public bool? PayOnDelivery { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; } = new List<OrderProducts>();
    }
}
