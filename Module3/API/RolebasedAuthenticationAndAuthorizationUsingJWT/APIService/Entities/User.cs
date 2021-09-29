using System;
using System.Collections.Generic;
namespace APIService.Entities
{
    public partial class User
    {
        public string Uid { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
