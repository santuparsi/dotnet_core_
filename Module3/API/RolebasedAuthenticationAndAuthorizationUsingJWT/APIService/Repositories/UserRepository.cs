using APIService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Repositories;
namespace APIService.Repositories
{
    public class UserRepository : IUserRepository
    {
        AuthenticationDBContext authenticationDB = new AuthenticationDBContext();
        public User GetUser(string Uid)
        {
            return authenticationDB.Users.Find(Uid);
        }

        public List<User> GetUsers()
        {
            return authenticationDB.Users.ToList();
        }

        public User ValidateUser(string Uname, string Pwd)
        {
            return authenticationDB.Users.SingleOrDefault(u => u.Username == Uname && u.Password == Pwd);
        }
    }
}
