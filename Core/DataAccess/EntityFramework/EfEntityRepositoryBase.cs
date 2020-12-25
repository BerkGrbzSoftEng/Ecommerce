using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task<TEntity> Get(int id)
        {
            using (var context=new TContext())
            {
                var obj = context.Set<TEntity>().FindAsync(id);
                return await obj;
            }
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task<bool> Add(TEntity entity)
        {
            using (var context = new TContext())
            {

                var result = context.Add(entity);
                result.State = EntityState.Added;
                if (await context.SaveChangesAsync() > 0)
                {
                    return true;
                }

                return false;
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var result = context.Remove(entity);
                result.State = EntityState.Deleted;
                if (await context.SaveChangesAsync() > 0)
                {
                    return true;

                }

                return false;
            }
        }

        public async Task<bool> Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var result = context.Update(entity);
                result.State = EntityState.Modified;
                if (await context.SaveChangesAsync() > 0)
                {
                    return true;

                }

                return false;
            }
        }

        public async Task<decimal> Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column)
        {
            using (var context=new TContext())
            {
                return await context.Set<TEntity>().Where(predicate).MaxAsync(column);
            }
        }

        public async Task<decimal> Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().Where(predicate).MinAsync(column);
            }
        }

        public async Task<int?> _Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int?>> column)
        {
            using (var context = new TContext())
            {
                Nullable<int> result = await context.Set<TEntity>().Where(predicate).MaxAsync(column);
                return result;
            }
        }

        public async Task<int?> _Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int?>> column)
        {
            using (var context = new TContext())
            {
                Nullable<int> result= await context.Set<TEntity>().Where(predicate).MinAsync(column);
                return result;
            }
        }

        public async Task<decimal> Sum(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal?>> column)
        {
            using (var context = new TContext())
            {
                decimal result = await context.Set<TEntity>().Where(predicate).SumAsync(column) ?? 0;
                return result;
            }
        }

        public async Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = new TContext())
            {
                int result = await context.Set<TEntity>().Where(predicate).CountAsync();
                return result;
            }
        }
    }
}


