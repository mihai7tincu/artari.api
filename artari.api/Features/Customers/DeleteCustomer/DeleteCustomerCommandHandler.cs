using artari.entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Features.Customers.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {

        private readonly ArtariDbContext _context;

        public DeleteCustomerCommandHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Customers
                               .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (entity == null)
                throw new Exception("Customer not found");

            _context.Customers.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
