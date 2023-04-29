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
        internal static List<MenuItem> menuItems;
        public LoginPage()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
            // Initialize employees
            
            //use first waiter for testing
            waiters.Add(new Waiter(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "waiter", "password", 111111));
            waiters.Add(new Waiter(new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, "Pikachu921", "Thunderbolt5", 944731));
            waiters.Add(new Waiter(new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 }, "RogerM1998", "So%2j82", 156735));

            //Create Menu Items
            menuItems = new List<MenuItem>();
            CreateMenuItems();

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
                    foreach (Waiter waiter in waiters)
                    {
                        if (waiter.getEmployeeID() == Int32.Parse(username))
                        {
                            currentWaiter = waiter;
                            break;
                        }
                    }
                    WelcomeForm welcomeForm = new WelcomeForm();
                    welcomeForm.Show();
                    this.Hide();
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

        public void CreateMenuItems()
        {
            menuItems.Add(new MenuItem("Pork Nachos", 8.5, "Appetizer"));
            menuItems.Add(new MenuItem("Catfish Bites", 6.5, "Appetizer"));
            menuItems.Add(new MenuItem("Chicken Nachos", 8.5, "Appetizer"));
            menuItems.Add(new MenuItem("Fried Veggies", 6.5, "Appetizer"));

            menuItems.Add(new MenuItem("House Salad", 7.5, "Salad"));
            menuItems.Add(new MenuItem("Caeser Salad", 7.5, "Salad"));
            menuItems.Add(new MenuItem("Sweet Potato Chicken Salad", 11.5, "Salad"));
            menuItems.Add(new MenuItem("Wedge Salad", 7.5, "Salad"));

            menuItems.Add(new MenuItem("Caribbean Chicken", 11.5, "Entree"));
            menuItems.Add(new MenuItem("Shrimp and Grits", 13.5, "Entree"));
            menuItems.Add(new MenuItem("Seared Tuna", 15, "Entree"));
            menuItems.Add(new MenuItem("New York Strip Steak", 17, "Entree"));

            menuItems.Add(new MenuItem("Mushroom Swiss Burger", 11, "Burger"));
            menuItems.Add(new MenuItem("Bacon Cheeseburger", 11, "Burger"));
            menuItems.Add(new MenuItem("Carolina Burger", 11, "Burger"));
            menuItems.Add(new MenuItem("Vegan Boca Burger", 10.5, "Burger"));

            menuItems.Add(new MenuItem("Coke", 2, "Beverage"));
            menuItems.Add(new MenuItem("Lemonade", 2, "Beverage"));
            menuItems.Add(new MenuItem("Sweet Tea", 2, "Beverage"));
            menuItems.Add(new MenuItem("Coffee", 2, "Beverage"));
        }

        internal static MenuItem GetMenuItem(String name)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.getName().Equals(name))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
