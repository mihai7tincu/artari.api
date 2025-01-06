using artari.entities;
using artari.entities.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ArtariDbContext _context;

        public ProductController(ArtariDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _context.Products.Where(x => x.Id > 0).ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
            {
                return NotFound("Product not found");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(
                //await _context.Products.Where(x => x.Id > 0).ToListAsync()
                );
        }

        [HttpPut]
        public async Task<ActionResult<Product>> UpdateProduct([FromBody]Product updatedProduct)
        {
            var dbProduct = await _context.Products.FindAsync(updatedProduct.Id);

            if (dbProduct is null)
            {
                return NotFound("Product not found");
            }

            dbProduct.Name = updatedProduct.Name;
            dbProduct.Description = updatedProduct.Description;
            dbProduct.Cultivar = updatedProduct.Cultivar;
            dbProduct.Height = updatedProduct.Height;
            dbProduct.ImageUrl = updatedProduct.ImageUrl;
            dbProduct.IsNew = updatedProduct.IsNew;
            dbProduct.IsSoldout = updatedProduct.IsSoldout;
            dbProduct.Price = updatedProduct.Price;
            dbProduct.TypeName = updatedProduct.TypeName;
            dbProduct.Priority = updatedProduct.Priority;
            dbProduct.Propagation = updatedProduct.Propagation;
            dbProduct.SpeciesName = updatedProduct.SpeciesName;
            dbProduct.Species = updatedProduct.Species;
            dbProduct.Type = updatedProduct.Type;

            dbProduct = updatedProduct;
            await _context.SaveChangesAsync();

            return Ok(
                //await _context.Products.Where(x => x.Id > 0).ToListAsync()
                );
        }

        [HttpDelete]
        public async Task<ActionResult<Product>> RemoveProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
            {
                return NotFound("Product not found");
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();
            return Ok(
                //await _context.Products.Where(x => x.Id > 0).ToListAsync()
                );
        }
    }
}
