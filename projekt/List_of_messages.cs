using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void Updatename(int ID, string newName)
        {
            foreach (Message msg in messages)
            {
                if (ID == msg.MessageUserID)
                {
                    msg.MessageUserName = newName;
                    
                }
            }
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

        public void allMessagesDelete(int ID)
        {
            string message = "";

            for (int i = 0; i < messages.Count; i++)
            {
                if (ID == messages[i].MessageUserID)
                {
                    messages.RemoveAt(i);
                    i--;
                }
            }
        }

        public void MessagesSave()
        {
            string message = "";
            foreach (Message msg in messages)
            {
                message += msg.MessageID + "\n" + msg.MessageUserID.ToString() + "\n" + msg.MessageUserName + "\n" + msg.MessageText + "\n" + msg.MessageTime + "\n";
            }
            System.IO.File.WriteAllText("messages.txt", message);
        }

        public void MessageLoad()
        {
            string path = "messages.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }

            string[] lines = System.IO.File.ReadAllLines("messages.txt");
            

            var j=0;
            int load_MessageID=0;
            int load_UserID = 0;
            string load_UserName = "";
            string load_Message = "";
            DateTime load_Time = DateTime.Now;

            foreach (string line in lines)
            {
                if (j == 0)
                {
                    load_MessageID = int.Parse(line);
                    j++;
                }
                else if (j == 1)
                {
                    load_UserID = int.Parse(line);
                    j++;
                }
                else if (j == 2)
                {
                    load_UserName = line;
                    j++;
                }
                else if (j == 3)
                {
                    load_Message = line;
                    j++;
                }
                else if (j == 4)
                {
                    load_Time = DateTime.Parse(line);

                    Message newMessage = new Message(load_MessageID, load_UserID, load_UserName, load_Message, load_Time);
                    messages.Add(newMessage);
                    j = 0;
                }
            }
        }

    }
}
