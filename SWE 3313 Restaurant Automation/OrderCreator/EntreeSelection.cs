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

namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    public partial class EntreeSelection : Form
    {
        TableObject table;
        internal EntreeSelection(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
        }

        private void CC_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Caribbean Chicken"));
            this.Close();
        }

        private void ShrimpGrits_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Shrimp and Grits"));
            this.Close();
        }

        private void Tuna_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Seared Tuna"));
            this.Close();
        }

        private void Steak_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("New York Strip Steak"));
            this.Close();
        }
    }
}
