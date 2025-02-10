using artari.entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Features.Products.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {

        private readonly ArtariDbContext _context;

        public DeleteProductCommandHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products
                               .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (entity == null)
                throw new Exception("Product not found");

            _context.Products.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
