using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductCatHiearchyManager:GenericManager<ProductCatHiearchy>,IProductCatHiearchyService
    {
        private IProductCatHiearchyDal _catHiearchyDal;

        public ProductCatHiearchyManager(IProductCatHiearchyDal catHiearchyDal):base(catHiearchyDal)
        {
            _catHiearchyDal = catHiearchyDal;
        }
    }
}
