﻿using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    public partial class SaladSelection : Form
    {
        TableObject table;
        internal SaladSelection(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
        }

        private void House_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("House Salad"));
            this.Close();
        }

        private void Caeser_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Caeser Salad"));
            this.Close();
        }

        private void SPC_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Sweet Potato Chicken Salad"));
            this.Close();
        }

        private void Wedge_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Wedge Salad"));
            this.Close();
        }
    }
}
