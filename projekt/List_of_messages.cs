using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public class List_of_messages
    {
        private List<Message> messages = new List<Message>();

        public void AddMessage(int userid,string username, string message)
        {
            Message newMessage = new Message(userid, username, message);
            messages.Add(newMessage);
            
        }

        public void showMessages()
        {
            string message = "";
            foreach (Message msg in messages)
            {
                message += msg.MessageID +". "+ msg.MessageUserID.ToString() + ". " + msg.MessageUserName +". "+msg.MessageText+". " +msg.MessageTime+ ".\n";
            }
            MessageBox.Show(message);
        }

        public string DisplayMessages()
        {
            string message = "";
            foreach (Message msg in messages.AsEnumerable().Reverse())
            {
                message += "UserID: "+msg.MessageUserID.ToString() + ", Name: " + msg.MessageUserName + ", Data: " + msg.MessageTime + Environment.NewLine;
                message += msg.MessageText + Environment.NewLine + Environment.NewLine;
            }
            
            return message;
        }
    }
}
