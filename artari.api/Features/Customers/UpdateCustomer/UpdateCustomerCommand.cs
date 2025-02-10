using MediatR;

namespace artari.api.Features.Customers.UpdateCustomer
{
    public class UpdateCustomerCommand :IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}