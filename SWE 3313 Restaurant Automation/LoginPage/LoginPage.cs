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
        Manager manager = new Manager();
        //manager id is 12345, password is Password123!
        List<Waiter> waiters = new List<Waiter>();
        internal static Waiter currentWaiter;
        public LoginPage()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
            // Initialize employees
            
            //use first waiter for testing
            waiters.Add(new Waiter(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "waiter", "password", 11111));
            waiters.Add(new Waiter(new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, "Pikachu921", "Thunderbolt5", 94473));
            waiters.Add(new Waiter(new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 }, "RogerM1998", "So%2j82", 15673));
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
                    foreach(Waiter waiter in waiters){
                        if (waiter.getEmployeeId().Equals(username))
                        {
                            currentWaiter = waiter;
                        }
                    }
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
