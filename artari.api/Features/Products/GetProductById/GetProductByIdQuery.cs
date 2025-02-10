using artari.entities.Products;
using MediatR;

namespace artari.api.Features.Products.GetProductById
{
    public record GetProductByIdQuery(int Id) : IRequest<Product?>
    {
    }
}
