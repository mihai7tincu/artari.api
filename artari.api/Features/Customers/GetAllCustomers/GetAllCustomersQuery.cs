using artari.entities.Customers;
using MediatR;

namespace artari.api.Features.Customers.GetAllCustomers
{
    public record GetAllCustomersQuery : IRequest<List<Customer>?>
    {
    }
}
