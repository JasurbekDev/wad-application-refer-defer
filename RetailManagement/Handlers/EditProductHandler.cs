using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class EditProductHandler : IRequestHandler<EditProductCommand, Product>
    {
        private readonly IRepository<Product> _productRepo;

        public EditProductHandler(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepo.UpdateAsync(request.Entity);
            return await _productRepo.GetByIdAsync(request.Entity.Id);
        }
    }
}
