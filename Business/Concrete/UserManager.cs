﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public void Update(User user)
        {
            if (user.Email != null)
            {
                var checkedDbUser = GetByMail(user.Email);
                if (checkedDbUser != null)
                {
                    user.PasswordHash = checkedDbUser.PasswordHash;
                    user.PasswordSalt = checkedDbUser.PasswordSalt;
                    user.Id = checkedDbUser.Id;
                    user.IsActive = checkedDbUser.IsActive;

                    _userDal.Update(user);
                }
            }
        }
    }
}
