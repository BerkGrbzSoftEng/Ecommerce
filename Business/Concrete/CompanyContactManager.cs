using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CompanyContactManager:ICompanyContactService
    {
        private ICompanyContactDal _companyContactDal;

        public CompanyContactManager(ICompanyContactDal companyContactDal)
        {
            _companyContactDal = companyContactDal;
        }
    }
}
