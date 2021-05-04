using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
    class ProductRepository : Repository<Product>, IProductRepository

    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }// context converting entity context

        public ProductRepository(DbContext context) : base(context)//  necessary constructor 
        {
        }

       

         async Task<Product> IProductRepository.GetWithCategoryByIdAsync(int productid)
        {

            return await _appDbContext.products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == productid);
        }
    }
}