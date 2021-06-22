using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class InsertCategoryHandler : IRequestHandler<InsertCategoryCommand, Category>
    {
        private readonly IRepository<Category> _categoryRepo;

        public InsertCategoryHandler(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> Handle(InsertCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepo.CreateAsync(request.Entity);
            return await _categoryRepo.GetByIdAsync(request.Entity.Id);
        }
    }
}
