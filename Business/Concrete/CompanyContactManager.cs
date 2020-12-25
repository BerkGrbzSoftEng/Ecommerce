using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CompanyContactManager:GenericManager<CompanyContact>,ICompanyContactService
    {
        private ICompanyContactDal _companyContactDal;

        public CompanyContactManager(ICompanyContactDal companyContactDal):base(companyContactDal)
        {
            _companyContactDal = companyContactDal;
        }
    }
}
