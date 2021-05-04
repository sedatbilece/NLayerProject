using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.Repositories
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class   
    {
        public readonly DbContext _context;
        public readonly DbSet<TEntity> _dbset;

        public Repository(DbContext context)// if  which entity comes in there we operating this 
        {
            _context = context;
            _dbset = context.Set<TEntity>();// dbset get context for entity and we  continue like this
        }



        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
           
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        // this func get parameter expression and return entity 
        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate);



        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return (IEnumerable<TEntity>)_dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await  _dbset.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;// updating all column 

            return entity;
        }
    }
}
