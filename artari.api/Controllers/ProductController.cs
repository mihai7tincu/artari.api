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
        public async Task<ActionResult<List<Product>>> GetAllProducts(CancellationToken cancellationToken)
        {
            var products = await _context.Products.Where(x => x.Id > 0).ToListAsync(cancellationToken);
            return Ok(products);
        }
    }
}
