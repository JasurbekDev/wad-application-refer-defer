using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Queries;

using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly IRepository<Category> _categoryRepo;

        public GetCategoryByIdHandler(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepo.GetByIdAsync(request.Id);
        }
    }
}
