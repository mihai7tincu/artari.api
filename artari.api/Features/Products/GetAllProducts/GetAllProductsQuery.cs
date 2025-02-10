using artari.entities.Products;
using MediatR;

namespace artari.api.Features.Products.GetAllProducts
{
    public record GetAllProductsQuery : IRequest<List<Product>?>
    {
      
    }
}
