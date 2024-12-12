using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public int UserID { get; set; }

        
        public Person(string username, string password, string email)
        {
            this.Username = username;
            this.Password = password;
            this.UserEmail = email;
            this.UserID = Globals.ID;
            Globals.ID++;
        }
    }
}
