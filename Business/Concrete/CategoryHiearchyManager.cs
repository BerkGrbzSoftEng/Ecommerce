using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CategoryHiearchyManager:GenericManager<CategoryHiearchy>,ICategoryHiearchyService
    {
        private ICategoryHiearchyDal _categoryHiearchyDal;

        public CategoryHiearchyManager(ICategoryHiearchyDal categoryHiearchyDal):base(categoryHiearchyDal)
        {
            _categoryHiearchyDal = categoryHiearchyDal;
        }
    }
}
