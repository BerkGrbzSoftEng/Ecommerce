using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductProductImageManager:GenericManager<ProductProductImage>,IProductProductImageService
    {
        private IProductProductImageDal productImageDal;

        public ProductProductImageManager(IProductProductImageDal productImageDal):base(productImageDal)
        {
            this.productImageDal = productImageDal;
        }
    }
}
