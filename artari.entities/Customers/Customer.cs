using artari.entities.Orders;

namespace artari.entities.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
