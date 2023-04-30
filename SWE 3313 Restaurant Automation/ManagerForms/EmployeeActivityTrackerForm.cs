using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    public partial class EmployeeActivityTrackerForm : Form
    {
        public EmployeeActivityTrackerForm()
        {
            InitializeComponent();
        }

        private void SetEmployeeButton(object sender, EventArgs e)
        {
            int id = Int32.Parse(EmployeeIDTextBox.Text);
            Waiter currentWaiter = GetWaiter(id);
        }

        private Waiter GetWaiter(int id)
        {
            foreach (Waiter waiter in LoginPage.waiters)
            {
                if (waiter.getEmployeeID() == id)
                {
                    return waiter;
                }
            }
            return null;
        }
    }
}
