using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductBrandManager:GenericManager<ProductBrand>,IProductBrandService
    {
        private IProductBrandDal _productBrandDal;

        public ProductBrandManager(IProductBrandDal productBrandDal):base(productBrandDal)
        {
            _productBrandDal = productBrandDal;
        }
    }
}
