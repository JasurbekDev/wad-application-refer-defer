using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly IRepository<Product> _productRepo;

        public InsertProductHandler(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        //it returns getbyId, Because this method has to return a response
        //But it cant return a class that CreateAsync takes as parameter
        public async Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            await _productRepo.CreateAsync(request.Entity);
            return await _productRepo.GetByIdAsync(request.Entity.Id);
        }
    }
}
