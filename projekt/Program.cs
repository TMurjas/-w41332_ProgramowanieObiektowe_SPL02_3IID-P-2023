namespace projekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        //static number


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form_Start login = new Form_Start();
            Globals.userList.AddUser("admin", "admin", "wsd@wp");
            Globals.userList.AddUser("user", "user", "wsd@wp");
            Globals.userList.AddAdmins("admin", "admin", "admin@ad.min");

            Globals.messageList.AddMessage(5, "d", "wsd@wp");
            Globals.messageList.AddMessage(45, "mamamia", "sdfdddddd");
            //Globals.messageList.showMessages();

            Application.Run(login);

            

            
            //Globals.users.showUsers();

            



        }
    }
}