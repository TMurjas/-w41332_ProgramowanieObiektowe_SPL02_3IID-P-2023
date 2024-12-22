using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            label1.Text = "Logged in as: " + Globals.userList.getUserName(Globals.UserID);
            textBox1.Text = Globals.userList.getUserName(Globals.UserID);
            label2.Text = "Email: " + Globals.userList.getUserEmail(Globals.UserID);
            textBox2.Text = Globals.userList.getUserEmail(Globals.UserID);

            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
            textBox5.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_log_in temp1 = new Form_log_in();
            temp1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var error = false;
            var message = "";
            if (Globals.userList.CheekRegystry(textBox1.Text) == true)
            {
                message += "This login is already taken \n";
                error = true;
            }
            if (error)
            { MessageBox.Show(message); }
            else
            {
                Globals.userList.Update_name(Globals.UserID, textBox1.Text);
                Globals.UserName = textBox1.Text;
                Globals.messageList.Updatename(Globals.UserID, textBox1.Text);

                Globals.userList.UserSave();
                MessageBox.Show("Name changed");
                refresh();
            }
        }

        private void refresh()
        {
            label1.Text = "Logged in as: " + Globals.userList.getUserName(Globals.UserID);
            textBox1.Text = Globals.userList.getUserName(Globals.UserID);
            label2.Text = "Email: " + Globals.userList.getUserEmail(Globals.UserID);
            textBox2.Text = Globals.userList.getUserEmail(Globals.UserID);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals.userList.Update_email(Globals.UserID, textBox2.Text);
            Globals.userList.UserSave();
            MessageBox.Show("Email changed");
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == Globals.userList.getUserPassword(Globals.UserID))
            {
                Globals.userList.Update_password(Globals.UserID, textBox4.Text);
                Globals.userList.UserSave();
                refresh();
                MessageBox.Show("Password changed");
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == Globals.userList.getUserPassword(Globals.UserID))
            {
                Globals.userList.UserDelete(Globals.UserID);
                Globals.UserID = -666;
                Globals.userList.UserSave();
                Globals.messageList.MessagesSave();
                MessageBox.Show("User deleted");
                this.Hide();
                Form_Start temp1 = new Form_Start();
                temp1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
            


        }
    }
}
