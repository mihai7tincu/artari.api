using artari.entities;
using artari.entities.Customers;
using MediatR;

namespace artari.api.Features.Customers.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer?>
    {
        private readonly ArtariDbContext _context;

        public GetCustomerByIdQueryHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task<Customer?> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.FindAsync(request.Id);
            return customer;
        }
    }
}
