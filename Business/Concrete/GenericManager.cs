using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.DataAccess;
using Core.Entities;

namespace Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        private IEntityRepositoryBase<TEntity> _gEntityRepositoryBase;

        public GenericManager(IEntityRepositoryBase<TEntity> gEntityRepositoryBase)
        {
            _gEntityRepositoryBase = gEntityRepositoryBase;
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }


        public async Task<ICollection<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _gEntityRepositoryBase.GetList(filter);
        }

        public async Task<bool> Add(TEntity entity)
        {
            return await _gEntityRepositoryBase.Add(entity);
        }

        public async Task<bool> Update(TEntity entity)
        {
            return await _gEntityRepositoryBase.Update(entity);
        }

        public async Task<bool> Delete(TEntity entity)
        {
            return await _gEntityRepositoryBase.Delete(entity);
        }



        public async Task<TEntity> GetTEntity(int id)
        {
            return await _gEntityRepositoryBase.Get(id);
        }

        public async Task<decimal> Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column)
        {
            return await _gEntityRepositoryBase.Max(predicate, column);
        }

        public async Task<decimal> Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal>> column)
        {
            return await _gEntityRepositoryBase.Min(predicate, column);
        }

        public async Task<int?> _Max(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int?>> column)
        {
            return await _gEntityRepositoryBase._Max(predicate, column);
        }

        public async Task<int?> _Min(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int?>> column)
        {
            return await _gEntityRepositoryBase._Min(predicate, column);
        }


        public async Task<decimal> Sum(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, decimal?>> column)
        {
            return await _gEntityRepositoryBase.Sum(predicate, column);
        }

        public async Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            return await _gEntityRepositoryBase.Count(predicate);
        }
    }
}
