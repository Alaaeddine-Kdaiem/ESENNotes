using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int role { get; set; }

        public User(int id, string username, string email, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
        }
        public User(string username, string email, string password, int role)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public User()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", username: " + username + " email: " + email + " password: " + password + " role: " + role;
            return s;
        }
    }
}
