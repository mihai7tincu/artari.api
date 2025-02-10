using artari.api.Features.Customers.CreateCustomer;
using artari.api.Features.Customers.DeleteCustomer;
using artari.api.Features.Customers.UpdateCustomer;
using artari.api.Features.Products.DeleteProduct;
using artari.entities.Customers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace artari.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        public CustomerController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var customers = await _sender.Send(new Features.Customers.GetAllCustomers.GetAllCustomersQuery());
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _sender.Send(new Features.Customers.GetCustomerById.GetCustomerByIdQuery(id));
            if (customer is null)
            {
                return NotFound("Customer not found");
            }
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddCustomer(CreateCustomerCommand command)
        {
            var customerId = await _sender.Send(command);
            return Ok(customerId);
        }

        [HttpPut]
        public async Task<ActionResult<int>> UpdateCustomer(UpdateCustomerCommand command)
        {
            var customerID = await _sender.Send(command);
            return Ok(customerID);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCustomer(int id)
        {
            await _sender.Send(new DeleteCustomerCommand(id));
            return Ok();
        }


    }
}
