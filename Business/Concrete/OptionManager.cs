using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class OptionManager:GenericManager<Option>,IOptionService
    {
        private IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal):base(optionDal)
        {
            _optionDal = optionDal;
        }
    }
}
