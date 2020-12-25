using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class UserManager:GenericManager<User>,IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal):base(userDal)
        {
            _userDal = userDal;
        }
    }
}
