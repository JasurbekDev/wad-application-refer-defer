using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class EditCategoryHandler : IRequestHandler<EditCategoryCommand, Category>
    {
        private readonly IRepository<Category> _categoryRepo;

        public EditCategoryHandler(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> Handle(EditCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepo.UpdateAsync(request.Entity);
            return await _categoryRepo.GetByIdAsync(request.Entity.Id);
        }
    }
}
