using artari.entities;
using artari.entities.Customers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Features.Customers.GetAllCustomers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomersQuery, List<Customer>?>
    {
        private readonly ArtariDbContext _context;

        public GetAllCustomerQueryHandler(ArtariDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>?> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _context.Customers.Where(x => x.Id > 0).ToListAsync();
            return customers;
        }
    }
}
