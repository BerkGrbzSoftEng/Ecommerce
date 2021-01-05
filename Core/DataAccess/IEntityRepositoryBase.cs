using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> Get(int id);
        Task<List<TEntity>> GetList(Expression<Func<TEntity,bool>> filter=null);
        Task<bool> Add(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<bool> Delete(int Id);
        Task<bool> Update(TEntity entity);
        Task<decimal> Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column);
        Task<decimal> Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column);
        Task<Nullable<int>> _Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<int>>> column);
        Task<Nullable<int>> _Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<int>>> column);
        Task<decimal> Sum(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<decimal>>> column);
        Task<int> Count(Expression<Func<TEntity, bool>> predicate);

    }
}
