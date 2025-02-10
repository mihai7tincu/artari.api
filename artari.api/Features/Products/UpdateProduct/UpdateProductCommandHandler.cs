using artari.entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Features.Products.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly ArtariDbContext _context;

        public UpdateProductCommandHandler(ArtariDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

            var product = await _context.Products.FindAsync(request.Id);

            product.Name = request.Name;
            product.Cultivar = request.Cultivar;
            product.Description = request.Description;
            product.Height = request.Height;
            product.ImageUrl = request.ImageUrl;
            product.IsNew = request.IsNew;
            product.IsSoldout = request.IsSoldout;
            product.Price = request.Price;
            product.Type = request.Type;
            product.TypeName = request.TypeName;
            product.Priority = request.Priority;
            product.Propagation = request.Propagation;
            product.SpeciesName = request.SpeciesName;
            product.Species = request.Species;

            await _context.SaveChangesAsync();
            return product.Id;
        }
    }
}


