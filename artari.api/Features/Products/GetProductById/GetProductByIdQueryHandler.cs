using artari.entities;
using artari.entities.Products;
using MediatR;

namespace artari.api.Features.Products.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product?>
    {

        private readonly ArtariDbContext _context;

        public GetProductByIdQueryHandler(ArtariDbContext context)
        {
            _context = context;
        }


        public async Task<Product?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var req = new GetProductByIdQuery(1);
            var product = await _context.Products.FindAsync(request.Id);
            return product;
        }
    }
}
