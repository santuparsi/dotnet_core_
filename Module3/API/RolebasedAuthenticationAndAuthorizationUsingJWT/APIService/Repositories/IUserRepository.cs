using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Entities;
namespace APIService.Repositories
{
    interface IUserRepository
    {
        User ValidateUser(string Uname, string Pwd);
        List<User> GetUsers();
        User GetUser(string Uid);
       
    }
}
