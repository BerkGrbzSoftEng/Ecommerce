using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class OptionManager:IOptionService
    {
        private IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal = optionDal;
        }
    }
}
