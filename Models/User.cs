using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, string password, string fullname)
        {
            Username = username;
            Password = password;
            FullName = fullname;
        }



    }
}
