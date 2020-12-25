using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class CompanyDetailManager:GenericManager<CompanyDetail>,ICompanyDetailSerivce
    {
        private ICompanyDetailDal _companyDetailDal;

        public CompanyDetailManager(ICompanyDetailDal companyDetailDal):base(companyDetailDal)
        {
            _companyDetailDal = companyDetailDal;
        }
    }
}
