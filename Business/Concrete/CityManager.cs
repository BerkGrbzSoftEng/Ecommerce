using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CityManager:GenericManager<City>,ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal):base(cityDal)
        {
            _cityDal = cityDal;
        }
    }
}
