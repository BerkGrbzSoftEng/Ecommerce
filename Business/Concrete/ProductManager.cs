using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductManager:GenericManager<Product>,IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal):base(productDal)
        {
            _productDal = productDal;
        }
    }
}
