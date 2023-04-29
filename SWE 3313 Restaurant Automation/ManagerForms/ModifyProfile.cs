using SWE_3313_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    public partial class ModifyProfile : Form
    {
        public ModifyProfile()
        {
            InitializeComponent();
        }

        //Deletes employee based off employee id
        private void DeleteProfileButtonClick(object sender, EventArgs e)
        {
            Waiter deleteWaiter = GetWaiter(EmployeeIDTextBox.Text);
            if (deleteWaiter != null)
            {
                deleteWaiter.RemoveWaiterFromFile();
                LoginPage.waiters.Remove(deleteWaiter);
                MessageBox.Show("Employee successfully deleted");
                this.Close();
            }
            else
            {
                MessageBox.Show("Employee with that Employee ID does not exist");
            }
        }

        //Changes username and or id if is not already taken
        private void ConfirmChangesButtonClick(object sender, EventArgs e)
        {
            String newUsername = NewUsernameTextBox.Text;
            String newID = NewEmployeeIDTextBox.Text;
            if (newUsername != "")
            {
                bool usernameTaken = false;
                foreach (Waiter waiter in LoginPage.waiters)
                {
                    if (waiter.GetUsername().Equals(newUsername, StringComparison.OrdinalIgnoreCase)){
                        usernameTaken = true;
                    }
                }
                if (usernameTaken)
                {
                    MessageBox.Show("New username is already being used by another employee");
                }
                else
                {
                    GetWaiter(EmployeeIDTextBox.Text).SetUsername(newUsername);
                    MessageBox.Show("Sucessfully changed username!");
                    this.Close();
                }
            }
            if (newID != "")
            {
                bool idTaken = false;
                foreach (Waiter waiter in LoginPage.waiters)
                {
                    if (waiter.getEmployeeID() == Int32.Parse(newID))
                    {
                        idTaken = true;
                    }
                }
                if (idTaken)
                {
                    MessageBox.Show("New ID is already being used by another employee");
                }
                else
                {
                    Waiter editWaiter = GetWaiter(EmployeeIDTextBox.Text);
                    if (editWaiter != null)
                    {
                        editWaiter.RemoveWaiterFromFile();
                        editWaiter.SetUsername(newUsername);
                        editWaiter.AddWaiterToFile();
                        editWaiter.setEmployeeID(Int32.Parse(newID));
                        MessageBox.Show("Sucessfully changed ID");
                        this.Close();
                    }
                }
            }
        }

        //Finds waiter of given employee id
        private Waiter GetWaiter(String EmployeeID)
        {
            foreach (Waiter waiter in LoginPage.waiters)
            {
                if (waiter.getEmployeeID().ToString().Equals(EmployeeID))
                {
                    return waiter;
                }
            }
            return null;
        }
    }
}
