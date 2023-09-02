using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Login
    {
        public string email { get; set; }
        public string password { get; set; }

        public Login(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public Login()
        {
        }
    }
}
