using artari.entities;
using artari.entities.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Features.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>?>
    {
        private readonly ArtariDbContext _context;

        public GetAllProductsQueryHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>?> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {

            var products = await _context.Products.Where(x => x.Id > 0).ToListAsync();
            return products;
        }
    }
}
