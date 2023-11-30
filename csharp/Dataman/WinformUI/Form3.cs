using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinformUI
{
    public partial class Form3 : Form
    {
        private const string ValidUsername = "user";
        private const string ValidPassword = "1234";

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;
           

            if (ValidateLogin(enteredUsername, enteredPassword))
            {
                // Successful login
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                
            }
            else
            {
                // Failed login                                              
                MessageBox.Show("Invalid username or password.");

                int attempt = 3;
                if (attempt == 3)
                {
                    MessageBox.Show("Here is a hint..\nUsername: user\nPassword: 1234");
                }

            }
        }       

        private bool ValidateLogin(string username, string password)
        {
            // Perform your authentication logic here
            return username == ValidUsername && password == ValidPassword;
        }
    }
}
