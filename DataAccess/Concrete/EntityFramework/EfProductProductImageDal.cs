using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Models;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductProductImageDal:EfEntityRepositoryBase<ProductProductImage,EcommerceDbContext>,IProductProductImageDal
    {
    }
}
