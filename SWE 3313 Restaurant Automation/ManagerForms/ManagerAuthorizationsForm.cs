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
    public partial class ManagerAuthorizationsForm : Form
    {
        public ManagerAuthorizationsForm()
        {
            InitializeComponent();
        }

        private void SelectEmployeeAuthorizationButtonClick(object sender, EventArgs e)
        {
            Waiter currentWaiter = getWaiter(Int32.Parse(EmployeeAuthorizationTextBox.Text));
            if (currentWaiter != null) 
            {
                DialogResult result = MessageBox.Show("Allow Refunds", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    currentWaiter.setRefundPermission(true);
                }
                else
                {
                    currentWaiter.setRefundPermission(false);
                }
            }
        }

        private Waiter getWaiter(int ID)
        {
            foreach (Waiter waiter in LoginPage.waiters)
            {
                if (waiter.getEmployeeID() == ID)
                {
                    return waiter;
                }
            }
            return null;
        }
    }
}
