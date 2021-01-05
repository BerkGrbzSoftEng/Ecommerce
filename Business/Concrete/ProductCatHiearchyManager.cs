using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductCatHiearchyManager:IProductCatHiearchyService
    {
        private IProductCatHiearchyDal _catHiearchyDal;

        public ProductCatHiearchyManager(IProductCatHiearchyDal catHiearchyDal)
        {
            _catHiearchyDal = catHiearchyDal;
        }
    }
}
