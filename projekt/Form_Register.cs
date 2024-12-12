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
    public partial class Form_Register : Form
    {

        public Form_Register()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Start temp1 = new Form_Start();
            temp1.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var error = false;
            var message = "";

            if (textBox1.Text == "")
            {
                message += "Please enter your login \n";
                error = true;
            }
            if (textBox2.Text == "")
            {
                message += "Please enter your email\n";
                error = true;
            }
            if (textBox3.Text == "")
            {
                message += "Please enter your password\n";
                error = true;
            }

            if (error){MessageBox.Show(message);}
            else
            {
                Globals.userList.AddUser(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Succes");
                this.Hide();
                Form_Start temp1 = new Form_Start();
                temp1.ShowDialog();
                this.Close();
            }

        }
    }
}
