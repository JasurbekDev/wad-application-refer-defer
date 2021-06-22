using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class InsertProductCommand : IRequest<Product>
    {
        public Product Entity { get; set; }

        public InsertProductCommand(Product product)
        {
            Entity = product;
        }
    }
}
