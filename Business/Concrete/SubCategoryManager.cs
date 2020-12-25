using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class SubCategoryManager:GenericManager<SubCategory>,ISubCategoryService
    {
        private ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal):base(subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }
    }
}
