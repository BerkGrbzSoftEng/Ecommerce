using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class MainCategoryManager:GenericManager<MainCategory>,IMainCategoryService
    {
        private IMainCategoryDal _mainCategoryDal;

        public MainCategoryManager(IMainCategoryDal mainCategoryDal):base(mainCategoryDal)
        {
            _mainCategoryDal = mainCategoryDal;
        }
    }
}
