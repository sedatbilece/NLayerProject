using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(DbContext context) : base(context)//  necessary constructor 
        {
        }



        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await _appDbContext.categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == CategoryId);
        }
    }
}
