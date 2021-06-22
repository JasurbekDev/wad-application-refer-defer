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
    public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<Category>>
    {
        private readonly IRepository<Category> _categoryRepo;

        public GetCategoriesHandler(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        public async Task<IEnumerable<Category>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepo.GetAllAsync();
        }
    }
}
