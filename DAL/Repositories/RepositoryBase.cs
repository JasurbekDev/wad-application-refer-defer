using DAL;

namespace DAL.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly ProductDbContext _context;

        protected RepositoryBase(ProductDbContext context)
        {
            _context = context;
        }
    }
}
