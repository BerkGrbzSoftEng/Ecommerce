using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CountryManager:GenericManager<Country>,ICountryService
    {
        private ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal):base(countryDal)
        {
            _countryDal = countryDal;
        }
    }
}
