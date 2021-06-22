using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class DeleteCategoryCommand : IRequest<Category>
    {
        public int Id { get; set; }

        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
