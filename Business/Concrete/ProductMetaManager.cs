using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ProductMetaManager:IProductMetaService
    {
        private IProductMetaDal _productMetaDal;

        public ProductMetaManager(IProductMetaDal productMetaDal)
        {
            _productMetaDal = productMetaDal;
        }
    }
}
