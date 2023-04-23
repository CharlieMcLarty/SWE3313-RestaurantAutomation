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
    public partial class Order_Table_1 : Form
    {
        public Order_Table_1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");

        }

        private void Order_Appetizers_Click(object sender, EventArgs e)
        {
            Apps_Table_1 apps_Table_1 = new Apps_Table_1();
            apps_Table_1.Show();
            this.Close();
        }
    }
}
