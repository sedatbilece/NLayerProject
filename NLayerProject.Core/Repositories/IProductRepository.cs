using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
    public interface IProductRepository : IRepository<Category>
    {

        Task<Category> GetWithCategoryByIdAsync(int productid);

    }
}
