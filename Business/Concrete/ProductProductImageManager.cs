using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductProductImageManager:IProductProductImageService
    {
        private IProductProductImageDal productImageDal;

        public ProductProductImageManager(IProductProductImageDal productImageDal)
        {
            this.productImageDal = productImageDal;
        }
    }
}
