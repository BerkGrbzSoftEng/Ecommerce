using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductOptionManager:GenericManager<ProductOption>,IProductOptionService
    {
        private IProductOptionDal _productOptionDal;

        public ProductOptionManager(IProductOptionDal productOptionDal):base(productOptionDal)
        {
            _productOptionDal = productOptionDal;
        }
    }
}
