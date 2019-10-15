using BL.Managers.Interfaces;
using Data.Database;
using Data.Repositories.Interfaces;
using Data.Repositories;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Util;

namespace BL.Managers
{
    public class AuthManager : IAuthManager
    {
        public User FindUser(string userName, string passwordHash)
        {
            IAuthRepository authRepo = new AuthRepository();
            return authRepo.FindUser(userName, HashHelper.GetMD5HashData(passwordHash));
        }
    }
}
