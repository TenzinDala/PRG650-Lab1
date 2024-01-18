using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string userName = UserName_textBox.Text;
            string passWord = Password_textBox.Text;

            
            LoginAuthenticator loginAuthenticator = new LoginAuthenticator(userName, passWord);
            bool? returnValue = loginAuthenticator.Authenticate();
            if (returnValue == null)
            {
                MessageBox.Show("Both UserName and Password are required");
            }
            else if (returnValue == false)
            {
                MessageBox.Show("The authentication has Failed");
                UserName_textBox.Text = "";
                Password_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Authentication was successfuly. Press any key to exit.");
            }
        }
    }
}
