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

namespace SWE_3313_Restaurant_Automation
{
    public partial class AppetizerSelection : Form
    {
        TableObject table;

        internal AppetizerSelection(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");


        }

        private void Pork_Nachos_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Pork Nachos"));
        }

        private void Catfish_Bites_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Catfish Bites"));
        }

        private void Chicken_Nachos_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Chicken Nachos"));
        }

        private void Fried_Veggies_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Fried Veggies"));
            Apps_Finished_Click(this, new EventArgs());
        }

        private void Apps_Finished_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
    


}
