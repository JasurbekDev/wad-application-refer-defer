using DAL.Models;
using DAL.Repositories;
using MediatR;
using RetailManagement.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagement.Handlers
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, Category>
    {
        private readonly IRepository<Category> _categoryRepo;

        public DeleteCategoryHandler(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await _categoryRepo.DeleteAsync(request.Id);
            return await _categoryRepo.GetByIdAsync(request.Id);
        }
    }
}
