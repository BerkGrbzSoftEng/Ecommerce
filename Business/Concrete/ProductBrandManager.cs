using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductBrandManager:IProductBrandService
    {
        private IProductBrandDal _productBrandDal;

        public ProductBrandManager(IProductBrandDal productBrandDal)
        {
            _productBrandDal = productBrandDal;
        }
    }
}
