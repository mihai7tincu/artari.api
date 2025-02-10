using artari.entities;
using artari.entities.Products;
using MediatR;

namespace artari.api.Features.Products.CreateProduct
{

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly ArtariDbContext _context;

        public CreateProductCommandHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            {
                var product = new Product
                {
                    Name = request.Name,
                    Cultivar = request.Cultivar,
                    Description = request.Description,
                    Height = request.Height,
                    ImageUrl = request.ImageUrl,
                    IsNew = request.IsNew,
                    IsSoldout = request.IsSoldout,
                    Price = request.Price,
                    Type = request.Type,
                    TypeName = request.TypeName,
                    Priority = request.Priority,
                    Propagation = request.Propagation,
                    SpeciesName = request.SpeciesName,
                    Species = request.Species
                };

                await _context.Products.AddAsync(product, cancellationToken);
                await _context.SaveChangesAsync();


                return product.Id;
            }

        }
    }
}
