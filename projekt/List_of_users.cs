using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projekt
{
    public class List_of_users
    {
        private List<Person> users = new List<Person>();

        public void AddUser(string username, string password,string email)
        {
            Users user = new Users(username, password, email);
            users.Add(user);
            
        }
        public void AddAdmins(string username, string password, string email)
        {
            Admins user = new Admins(username, password, email);
            users.Add(user);

        }

        public void showUsers()
        {
            string message = "";
            foreach (Person user in users)
            {
                message +=  user.UserID.ToString() +" "+ user.Username + '\n';
            }
            MessageBox.Show(message);
        }

        public void cheek_user(string User,string Password)
        {
            var error = true;
            foreach (Person user in users)
            {
                if ((user.Username == User) && (user.Password == Password))
                {
                    Globals.UserID = user.UserID;
                    Globals.UserName = user.Username;
                    error = false;
                    break;
                }
            }

            if (error)
            {
                MessageBox.Show("Wrong username or password");
            }

        }



    }
}
