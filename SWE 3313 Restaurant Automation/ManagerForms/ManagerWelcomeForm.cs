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
    public partial class ManagerWelcomeForm : Form
    {
        public ManagerWelcomeForm()
        {
            InitializeComponent();
        }

        private void CreateProfileButtonClick(object sender, EventArgs e)
        {
            CreateProfileForm createProfileForm = new CreateProfileForm();
            createProfileForm.Show();
        }

        private void ModifyProfileButtonClick(object sender, EventArgs e)
        {
            ModifyProfile modifyProfile = new ModifyProfile();
            modifyProfile.Show();
        }
    }
}
