using Microsoft.VisualBasic.Logging;
using System.ComponentModel.Design.Serialization;

namespace projekt
{
    public partial class Form_Start : Form
    {


        public Form_Start()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Register temp1 = new Form_Register();
            temp1.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void Login_Click(object sender, EventArgs e)
        {
            Globals.userList.cheek_user(textBox1.Text, textBox2.Text);

            if (Globals.UserID != -666)
            {
                this.Hide();
                Form_log_in temp2 = new Form_log_in();
                temp2.ShowDialog();
                this.Close();
            }


        }

        private void Form_Start_Load(object sender, EventArgs e)
        {

        }
    }
}
