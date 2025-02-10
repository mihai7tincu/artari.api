using artari.api.Features.Products.CreateProduct;
using System.Reflection.Metadata;
using artari.entities;
using MediatR;
using artari.entities.Products;
using artari.entities.Customers;

namespace artari.api.Features.Customers.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly ArtariDbContext _context;

        public CreateCustomerCommandHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                Name = request.Name,
                Phone = request.Phone,
                Address = request.Address
            };

            await _context.Customers.AddAsync(customer, cancellationToken);
            await _context.SaveChangesAsync();


            return customer.Id;
        }
    }
}
