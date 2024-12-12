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
    public partial class Form_log_in : Form
    {
        public Form_log_in()
        {
            InitializeComponent();
            textBox1.Text = " ";
            label3.Text = "Logged in as: " + Globals.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.UserID = -666;
            this.Hide();
            Form_Start temp1 = new Form_Start();
            temp1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            Globals.messageList.AddMessage(Globals.UserID, Globals.UserName, textBox2.Text);
            textBox2.Text = "";
            refresh();


        }
        private void refresh()
        {
            textBox1.Text = Globals.messageList.DisplayMessages();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
