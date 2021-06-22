using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class EditProductCommand : IRequest<Product>
    {
        public Product Entity { get; set; }

        public EditProductCommand(Product product)
        {
            Entity = product;
        }
    }
}
