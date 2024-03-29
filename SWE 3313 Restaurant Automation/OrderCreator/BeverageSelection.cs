﻿using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    public partial class BeverageSelection : Form
    {
        TableObject table;
        internal BeverageSelection(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
            this.table = table;
        }

        private void Coke_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Pork Nachos"));
            this.Close();
        }

        private void Lemonade_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Pork Nachos"));
            this.Close();
        }

        private void Tea_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Pork Nachos"));
            this.Close();
        }

        private void Coffee_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Pork Nachos"));
            this.Close();
        }
    }
}
