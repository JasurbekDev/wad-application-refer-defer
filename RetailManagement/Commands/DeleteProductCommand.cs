using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public int Id { get; set; }

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
