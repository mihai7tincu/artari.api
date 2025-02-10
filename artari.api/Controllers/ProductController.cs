using artari.api.Features.Products.CreateProduct;
using artari.api.Features.Products.DeleteProduct;
using artari.api.Features.Products.UpdateProduct;
using artari.entities;
using artari.entities.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ISender _sender;


        public ProductController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _sender.Send(new Features.Products.GetAllProducts.GetAllProductsQuery());
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _sender.Send(new Features.Products.GetProductById.GetProductByIdQuery(id));
            if (product is null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateProduct(CreateProductCommand command)
        {
            var productId = await _sender.Send(command);
            return Ok(productId);
        }

        [HttpPut]
        public async Task<ActionResult<int>> UpdateProduct(UpdateProductCommand command)
        {
            var productId = await _sender.Send(command);
            return Ok(productId);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _sender.Send(new DeleteProductCommand(id));
            return Ok();
        }
    }
}
