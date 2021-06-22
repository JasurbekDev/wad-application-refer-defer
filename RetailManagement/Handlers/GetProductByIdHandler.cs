using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IRepository<Product> _productRepo;

        public GetProductByIdHandler(IRepository<Product> productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepo.GetByIdAsync(request.Id);
        }
    }
}
