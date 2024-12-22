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

        public void Update_name(int ID,string newName)
        {
            foreach (Person user in users)
            {
                if (ID== user.UserID)
                {
                    user.Username = newName;
                    break;
                }

            }
        }

        public string getUserPassword(int ID)
        {
            var password = "";
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    password = user.Password;
                    break;
                }
            }
            return password;
        }

        public void Update_email(int ID, string newEmail)
        {
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    user.UserEmail = newEmail;
                    break;
                }

            }
        }

        public void Update_password(int ID, string newPassword)
        {
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    user.Password = newPassword;
                    break;
                }

            }
        }

        public void UserDelete(int ID)
        {
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    Globals.messageList.allMessagesDelete(ID);
                    users.Remove(user);
                    break;
                }

            }
        }

        public string getUserName(int ID)
        {
            var name = "";
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    name = user.Username;
                    break;
                }
            }
            return name;   
        }

        public string getUserEmail(int ID)
        {
            var email = "";
            foreach (Person user in users)
            {
                if (ID == user.UserID)
                {
                    email = user.UserEmail;
                    break;
                }
            }
            return email;
        }

        public bool CheekRegystry(string User)
        {
            var error = false;
            foreach (Person user in users)
            {
                if (user.Username == User) 
                {
                    error = true;
                    break;
                }
            }
            return error;
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
