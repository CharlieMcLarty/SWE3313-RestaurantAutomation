using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SWE_3313_Project
{
    public partial class Order : Form

    {
        public int tableID;
        public Order()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Order.ActiveForm.Close();
        }

        private void Add_Seat_1_Click(object sender, EventArgs e)
        {
            OrderObject order = new OrderObject(tableID, LoginPage.currentWaiter.getEmployeeId());
        }
    }
}
