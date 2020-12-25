using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class AddressManager:GenericManager<Address>,IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal):base(addressDal)
        {
            _addressDal = addressDal;
        }
    }
}
