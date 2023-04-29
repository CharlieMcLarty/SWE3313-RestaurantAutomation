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
        internal TableObject table;
        public Color StatusColor { get; set; }
        internal TableStatus(Color initialColor, TableObject table)
        {

            InitializeComponent();
            this.table = table;
            //Checks radio box for current table status
            if (initialColor == Color.Green)
            {
                radioButton1.Checked = true;
            }
            else if (initialColor == Color.Red)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }

        }

        private void dataSeat_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void New_Order_Click(object sender, EventArgs e)
        {
            Order startOrder = new Order(table);
            startOrder.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButtonDirty_CheckedChanged(object sender, EventArgs e)
        {
            StatusColor = Color.Red;
        }

        private void radioButtonFull_CheckedChanged(object sender, EventArgs e)
        {
            StatusColor = Color.Yellow;
        }

        private void radioButtonClean_CheckedChanged(object sender, EventArgs e)
        {
            StatusColor = Color.Green;
        }



        //Resets tables current order
        private void button2_Click(object sender, EventArgs e)
        {
            table.CreateOrder();
        }

        //Creates receipt txt file in bin
        private void Payment_Click(object sender, EventArgs e)
        {
            String receiptAddress = "Order" + table.Order.getOrderID() + "Receipt.txt";
            DateTime dateTime = DateTime.Now;
            using (FileStream Stream = File.Create(receiptAddress))
            {
                AddText(Stream, "Order " + table.Order.getOrderID() + "\n" + LoginPage.currentWaiter.getEmployeeID() + "\n" + dateTime);
                foreach (MenuItem menuItem in table.Order.items)
                {
                    AddText(Stream, "\n\n" + menuItem.getName() + ", " + menuItem.price);
                }
                AddText(Stream, "\n\nTotal: $" + table.Order.getTotalPrice());
            }
        }

        //New order must be clicked before allowing any items to be added to order
        private void AddToOrderClick(object sender, EventArgs e)
        {
            if (table.Order != null)
            {
                Order startOrder = new Order(table);
                startOrder.Show();
            }
            else
            {
                Console.WriteLine("Create new order first");
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
