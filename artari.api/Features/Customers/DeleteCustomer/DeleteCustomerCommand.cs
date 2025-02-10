using MediatR;

namespace artari.api.Features.Customers.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteCustomerCommand() { }

        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
