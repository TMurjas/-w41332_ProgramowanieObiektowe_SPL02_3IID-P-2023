namespace projekt
{
    partial class Form_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 269);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 1;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(343, 41);
            button3.Name = "button3";
            button3.Size = new Size(137, 29);
            button3.TabIndex = 2;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(343, 141);
            button4.Name = "button4";
            button4.Size = new Size(137, 29);
            button4.TabIndex = 3;
            button4.Text = "Change";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(343, 409);
            button5.Name = "button5";
            button5.Size = new Size(148, 29);
            button5.TabIndex = 4;
            button5.Text = "Delete Account";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 27);
            textBox4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 11;
            label3.Text = "Old Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 246);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 12;
            label4.Text = "New Password:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 409);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(325, 27);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 386);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 14;
            label5.Text = "Password:";
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form_Settings";
            Text = "Form_Settings";
            Load += Form_Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}