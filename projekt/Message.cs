using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Message
    {
        public string MessageText { get; set; }
        public int MessageUserID { get; set; }
        public string MessageUserName { get; set; }
        public DateTime MessageTime { get; set; }
        public int MessageID { get; set; }
        public static int ID = 0;

        public Message(int userID, string userName,string message)
        {
            this.MessageText = message;
            this.MessageUserID = userID;
            this.MessageUserName = userName;
            this.MessageTime = DateTime.Now;
            this.MessageID = ID;
            ID++;
        }



    }
}
