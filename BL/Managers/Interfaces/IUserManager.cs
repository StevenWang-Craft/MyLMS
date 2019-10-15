using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Dto;

namespace BL.Managers.Interfaces
{
    public interface IUserManager
    {
        Task<UserDisplayDto> CreateUser(UserRegisterDto user);
        User FindUser(string userName, string password);
    }
}
