using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductImageManager:GenericManager<ProductImage>,IProductImageService
    {
        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal):base(productImageDal)
        {
            _productImageDal = productImageDal;
        }
    }
}
