using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class OptionGroupManager:GenericManager<OptionGroup>,IOptionGroupService
    {
        private IOptionGroupDal _optionGroupDal;

        public OptionGroupManager(IOptionGroupDal optionGroupDal):base(optionGroupDal)
        {
            _optionGroupDal = optionGroupDal;
        }
    }
}
