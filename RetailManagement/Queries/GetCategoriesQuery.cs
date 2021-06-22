using DAL.Models;
using MediatR;
using System.Collections.Generic;


namespace RetailManagement.Queries
{
    public class GetCategoriesQuery : IRequest<IEnumerable<Category>>
    {

    }
}
