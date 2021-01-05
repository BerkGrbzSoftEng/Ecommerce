using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CategoryHiearchyManager:ICategoryHiearchyService
    {
        private ICategoryHiearchyDal _categoryHiearchyDal;

        public CategoryHiearchyManager(ICategoryHiearchyDal categoryHiearchyDal)
        {
            _categoryHiearchyDal = categoryHiearchyDal;
        }
    }
}
