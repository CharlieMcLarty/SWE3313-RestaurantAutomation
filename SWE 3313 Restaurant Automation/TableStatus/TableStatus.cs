using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SWE_3313_Project
{
    public partial class TableStatus : Form
    {
        List<string> seat1 = new List<string>();
        List<string> seat2 = new List<string>();
        List<string> seat3 = new List<string>();
        List<string> seat4 = new List<string>();

        public TableStatus()
        {

            InitializeComponent();


        }

        private void dataSeat_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void New_Order_Click(object sender, EventArgs e)
        {
            Order startOrder = new Order();
            startOrder.Show();
        }

        private void Table_Status_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            TableStatus.ActiveForm.Close();
        }
    }
}
