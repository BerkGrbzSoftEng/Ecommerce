using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Aspects.Postsharp.CacheAspects;
using Core.Aspects.Postsharp.LogAspects;
using Core.CrossCuting.Caching.Microsoft;
using Core.CrossCutting.Logging.Log4Net.Loggers;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class UnitManager:IUnitService
    {
        private IUnitDal _unitDal;

        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }
         
        [LogAspect(typeof(FileLogger))]
        [CacheAspect(typeof(MemoryCacheManager),60)]
        public async Task<List<Unit>> GetAll()
        {
            return await _unitDal.GetList();
        }

        public async Task<bool> Add(Unit unit)
        {
            bool result = false;

            if (unit!=null)
            {
                result = await _unitDal.Add(unit);
                return result;
            }

            return result;
        }

        public async Task<bool> Update(Unit unit)
        {
            bool result = false;

            if (unit != null)
            {
                result = await _unitDal.Update(unit);
                return result;
            }

            return result;
        }

        public async Task<bool> Delete(Unit unit)
        {
            bool result = false;

            if (unit != null)
            {
                result = await _unitDal.Delete(unit);
                return result;
            }

            return result;
        }

        public async Task<bool> Delete(int unitId)
        {
            bool result = false;

            if (unitId != null)
            {
                result = await _unitDal.Delete(unitId);
                return result;
            }

            return result;
        }
    }
}
