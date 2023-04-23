﻿using System;
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
        internal TableObject table;
        public Color StatusColor { get; set; }
        public TableStatus(Color initialColor, TableObject table)
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
            Order startOrder = new Order();
            startOrder.tableID = table.GetTableID();
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
    }
}
