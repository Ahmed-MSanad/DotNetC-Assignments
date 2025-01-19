using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q2
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public bool AuthenticateUser(string username, string password)
        {
            return Username?.ToLower() == username.ToLower() && Password == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username.ToLower() == Username?.ToLower() && role.ToLower() == Role?.ToLower();
        }
    }
}
