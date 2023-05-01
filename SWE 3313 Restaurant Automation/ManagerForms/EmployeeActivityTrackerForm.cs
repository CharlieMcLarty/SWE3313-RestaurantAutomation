using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    public partial class EmployeeActivityTrackerForm : Form
    {
        bool waiterSelected;
        Waiter currentWaiter;
        public EmployeeActivityTrackerForm()
        {
            InitializeComponent();
        }

        //Finds waiter and displays their tables
        private void SetEmployeeButton(object sender, EventArgs e)
        {
            int id = Int32.Parse(EmployeeIDTextBox.Text);
            currentWaiter = GetWaiter(id);
            if (currentWaiter != null)
            {
                SetTables(currentWaiter);
                waiterSelected = true;
            }
        }

        //Returns waiter based on id
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

        //Changes label so show associated tables for waiter
        private void SetTables(Waiter waiter)
        {
            foreach (int i in waiter.assignedTables)
            {
                AssignedTablesLabel.Text += " " + i + ",";
            }
        }

        //Prints current tab items of entered table into list box
        private void ViewTabButtton_Click(object sender, EventArgs e)
        {
            if (waiterSelected)
            {
                if (currentWaiter.assignedTables.Contains(Int32.Parse(TableNumberTextBox.Text)))
                {
                    int index = currentWaiter.assignedTables.IndexOf(Int32.Parse(TableNumberTextBox.Text));
                    /*
                    foreach (MenuItem item in currentWaiter.tableList[index].Order.items)
                    {
                        TabListBox.Items.Add(item.getName());
                    }
                    */
                }
            }
            else
            {
                MessageBox.Show("Please select an employee first");
            }
        }


    }
}
