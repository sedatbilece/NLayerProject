using NLayerProject.Core.Repositories;
using NLayerProject.Core.UnitOfWork;
using NLayerProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        // if productrepository exist take if not new create
        public IProductRepository products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);


        public UnitOfWork(AppDbContext  appdb)
        {
            _context = appdb;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await  _context.SaveChangesAsync();
        }
    }
}
