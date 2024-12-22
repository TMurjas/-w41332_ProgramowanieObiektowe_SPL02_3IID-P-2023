using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Admins: Person
    {
        string Username { get; set; }
        string Password { get; set; }
        string UserEmail { get; set; }
        int UserID { get; set; }
        static int ID = 0;
        public Admins(string username,string email, string password) : base(username, email, password)
        {        }
    }
}
