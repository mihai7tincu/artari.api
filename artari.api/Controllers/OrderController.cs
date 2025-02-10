using artari.entities;
using artari.entities.Orders;
using artari.entities.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace artari.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ArtariDbContext _context;

        public OrderController(ArtariDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var orders = await _context.Orders
                .Include(x => x.OrderProducts).ThenInclude(x=> x.Product)
                .Where(x => x.Id > 0)
                .ToListAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Order>>> GetOrderById(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order is null)
            {
                return NotFound("Order not found");
            }

            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult<List<Order>>> AddOrder(Order order)
        {

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(
                //await _context.Orders.Where(x => x.Id > 0).ToListAsync()
                );
        }

        [HttpPut]
        public async Task<ActionResult<Order>> UpdateOrder([FromBody] Order updatedOrder)
        {
            var dbOrder = await _context.Orders.FindAsync(updatedOrder.Id);

            if (dbOrder is null)
            {
                return NotFound("Order not found");
            }

            dbOrder.OrderDate = updatedOrder.OrderDate;
            dbOrder.OrderProducts = updatedOrder.OrderProducts;
            dbOrder.OrderNotes = updatedOrder.OrderNotes;
            dbOrder.DeliveryAddress = updatedOrder.DeliveryAddress;


            // todo
            // stergi custom orderurile vechi
            // stergi customerul vechi
            // adaugi customer nou
            // adaugi custom orderele noi                                                                                                                                bgt6n 6

            dbOrder.Customer = updatedOrder.Customer;
            dbOrder.CustomerId = updatedOrder.Customer.Id;

            dbOrder = updatedOrder;
            await _context.SaveChangesAsync();

            return Ok(
                //await _context.Orders.Where(x => x.Id > 0).ToListAsync()
                );
        }

        [HttpDelete]
        public async Task<ActionResult<Order>> RemoveOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order is null)
            {
                return NotFound("Order not found");
            }

            _context.Orders.Remove(order);

            await _context.SaveChangesAsync();
            return Ok(
                //await _context.Orders.Where(x => x.Id > 0).ToListAsync()
                );
        }

    }
}
