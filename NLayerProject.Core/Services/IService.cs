using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IService <TEntity> where TEntity : class
    {


        // task for async 
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();


        //  as find (x=> x.id=..) 
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);


        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);


        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
    }
}
