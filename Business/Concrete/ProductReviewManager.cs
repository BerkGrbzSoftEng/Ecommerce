using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductReviewManager:IProductReviewService
    {
        private IProductReviewDal _productReviewDal;

        public ProductReviewManager(IProductReviewDal productReviewDal)
        {
            _productReviewDal = productReviewDal;
        }
    }
}
