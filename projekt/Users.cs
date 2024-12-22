using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekt
{
    internal class Users : Person
    {

        public Users(string username,  string email,string password) : base(username,email, password)
        {

        }
        public Users(int id,string username, string email, string password) : base(id,username, email, password)
        {

        }

    }
}
