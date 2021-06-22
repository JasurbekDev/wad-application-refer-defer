using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : RepositoryBase, IRepository<Category>
    {

        public CategoryRepository(ProductDbContext context) : base(context) { }

        public async Task CreateAsync(Category entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Category entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
