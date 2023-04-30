using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void FinishCreateProfile(object sender, EventArgs e)
        {
            string employeeID = employeeIDBox.Text;
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            foreach (Waiter waiter in LoginPage.waiters)
            {
                if (waiter.getEmployeeID() == Int32.Parse(employeeID) || Int32.Parse(employeeID) == LoginPage.manager.getEmployeeID())
                {
                    MessageBox.Show("Cannot create profile: Employee Id is already in use by another employee");
                    return;
                }
            }
            LoginPage.waiters.Add(new Waiter(null, username, password, Int32.Parse(employeeID)));
            this.Close();
        }
    }
}
