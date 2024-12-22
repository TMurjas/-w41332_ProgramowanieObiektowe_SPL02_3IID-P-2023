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

        
        public Person(string username,string email, string password)
        {
            this.Username = username;
            this.UserEmail = email;
            this.Password = password;
            this.UserID = Globals.ID;
            Globals.ID++;
        }
        public Person(int ID,string username, string email, string password)
        {
            this.Username = username;
            this.UserEmail = email;
            this.Password = password;
            this.UserID = ID;
            if (ID >= Globals.ID)
                Globals.ID=ID+1;
        }
    }
}
