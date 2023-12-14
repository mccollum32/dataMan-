using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WinformUI
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
       

        double FirstNumber;
        string Operation;

        //This sets the functionalty for the window to move around when clicked on the window not the menu bar
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        //This sets moveablity to the window since the window doesn't have a border to it.
        private void windowMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(windowMove);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void threeBtn_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void periodBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "/";
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");
            }

        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "*";
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");
            }
         
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {

            try
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "+";
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");
            }
            

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double SecondNumber;
                double Result;

                SecondNumber = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "Cannot divide by zero";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");

            }

        }


        private void subtracBTN_Click(object sender, EventArgs e)
        {
            try
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                Operation = "-";
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");

            }
           

        }

        private void plusNegBtn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
        }

        private void plusNegBtn2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void entBtn_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            try
            {
                SecondNumber = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Clear();
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Clear();
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Clear();
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero \nPlease try again.");

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Clear();
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid input!\nTry using integers.");
            }
            
        }

 
    }
}