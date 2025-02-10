using MediatR;

namespace artari.api.Features.Products.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteProductCommand() { }
        public DeleteProductCommand(int id) => Id = id;
    }
}
