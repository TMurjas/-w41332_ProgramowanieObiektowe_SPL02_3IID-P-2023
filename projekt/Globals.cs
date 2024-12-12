using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public static class Globals
    {
            public static int ID { get; set; }
            public static List_of_users userList = new List_of_users();
            public static List_of_messages messageList = new List_of_messages();
            public static int UserID { get; set; } = -666;
            public static string UserName { get; set; } = " ";
    }
}
