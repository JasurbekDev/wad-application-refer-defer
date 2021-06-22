using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly IRepository<Product> _productRepo;

        public DeleteProductHandler(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepo.DeleteAsync(request.Id);
            return await _productRepo.GetByIdAsync(request.Id);
        }
    }
}
