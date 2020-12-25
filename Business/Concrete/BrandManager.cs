using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class BrandManager:GenericManager<Brand>,IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal):base(brandDal)
        {
            _brandDal = brandDal;
        }
    }
}
