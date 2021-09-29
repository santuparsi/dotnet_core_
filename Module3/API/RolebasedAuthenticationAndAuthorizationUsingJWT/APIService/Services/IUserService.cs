using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Entities;

namespace APIService.Services
{
    public interface IUserService
    {
        User ValidateUser(string Uname, string Pwd);
        List<User> GetUsers();
        User GetUser(string Uid);
    }
}
