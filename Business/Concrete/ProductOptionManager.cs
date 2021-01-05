using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductOptionManager:IProductOptionService
    {
        private IProductOptionDal _productOptionDal;

        public ProductOptionManager(IProductOptionDal productOptionDal)
        {
            _productOptionDal = productOptionDal;
        }
    }
}
