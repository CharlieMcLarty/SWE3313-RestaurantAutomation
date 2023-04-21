using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_3313_Restaurant_Automation
{
    public partial class Table_3 : Form
    {
        public Table_3()
        {
            InitializeComponent();
        }

        private void Table_Ready_Click(object sender, EventArgs e)
        {
            WelcomeForm.ButtonColors["button1"] = Color.Green;
        }

        private void Table_Occupied_Click(object sender, EventArgs e)
        {
            WelcomeForm.ButtonColors["button1"] = Color.Yellow;
        }

        private void Table_Dirty_Click(object sender, EventArgs e)
        {
            WelcomeForm.ButtonColors["button1"] = Color.Red;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            WelcomeForm mainWelcome = new WelcomeForm();
            mainWelcome.ChangeButtonColors();
            mainWelcome.Show();
            this.Close();
        }
    }
}
