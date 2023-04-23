using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SWE_3313_Project;

namespace SWE_3313_Project
{
    public partial class LoginPage : Form 
    {
        
        public LoginPage()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = EmployeeIDBox.Text;
            string password = PasswordBox.Text;
            
            //Checks if user login is a waiter
            string[] users = File.ReadAllLines("WaiterLogin.txt");
            foreach (string user in users)
            {
                string[] credentials = user.Split(',');
                if (credentials[0] == username && credentials[1] == password)
                {
                    WelcomeForm welcomeForm = new WelcomeForm();
                    welcomeForm.Show();
                    this.Hide();
                    return;
                }
            }
            
            //Duplicate waiter code for manager with new welcomeForm
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "/bin/Image/J's Restaurant Login Icon.png";
        }

        private void EmployeeIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
