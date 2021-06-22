using DAL.Models;
using MediatR;

namespace RetailManagement.Commands
{
    public class InsertCategoryCommand : IRequest<Category>
    {
        public Category Entity { get; set; }

        public InsertCategoryCommand(Category entity)
        {
            Entity = entity;
        }
    }
}
