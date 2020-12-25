using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Business.Abstract
{
    public interface IGenericService<TEntity>:IDisposable
    {
        Task<ICollection<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null);
        Task<bool> Add(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<TEntity> GetTEntity(int id);
        Task<decimal> Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column);
        Task<decimal> Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column);
        Task<Nullable<int>> _Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<int>>> column);
        Task<Nullable<int>> _Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<int>>> column);
        Task<decimal> Sum(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, Nullable<decimal>>> column);
        Task<int> Count(Expression<Func<TEntity, bool>> predicate);
    }
}
