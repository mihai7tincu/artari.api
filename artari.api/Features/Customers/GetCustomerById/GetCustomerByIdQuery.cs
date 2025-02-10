using artari.entities.Customers;
using MediatR;

namespace artari.api.Features.Customers.GetCustomerById
{
    public record GetCustomerByIdQuery(int Id) : IRequest<Customer?>
    {
    }
}
