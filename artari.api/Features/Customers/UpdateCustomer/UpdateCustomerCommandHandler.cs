using artari.entities;
using MediatR;

namespace artari.api.Features.Customers.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        private readonly ArtariDbContext _context;

        public UpdateCustomerCommandHandler(ArtariDbContext context) {
            _context = context; 
        }


        public async Task<int> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.FindAsync(request.Id);

            customer.Name = request.Name;
            customer.Phone = request.Phone;
            customer.Address = request.Address;

            await _context.SaveChangesAsync();
            return customer.Id;
        }
    }
}
