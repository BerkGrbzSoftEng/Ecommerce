using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class UnitManager:GenericManager<Unit>,IUnitService
    {
        private IUnitDal _unitDal;

        public UnitManager(IUnitDal unitDal):base(unitDal)
        {
            _unitDal = unitDal;
        }
    }
}
