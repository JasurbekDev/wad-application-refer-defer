using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class EditCategoryCommand : IRequest<Category>
    {
        public Category Entity { get; set; }

        public EditCategoryCommand(Category entity)
        {
            Entity = entity;
        }
    }
}
