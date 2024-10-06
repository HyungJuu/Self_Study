using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signup.Models
{
    public class UserInformationModel
    {

        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        public UserInformationModel(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        
    }
}
