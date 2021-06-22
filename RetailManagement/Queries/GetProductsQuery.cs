using DAL.Models;
using MediatR;
using System.Collections.Generic;


namespace RetailManagement.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
