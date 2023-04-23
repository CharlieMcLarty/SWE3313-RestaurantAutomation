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
        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        public AppetizerSelection()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");


        }
        List<Item> appsOrder_Seat1 = new List<Item>();
        List<double> appsTotal = new List<double>();
        string appName;
        double appCost;

        //Table_1 table1 = new Table_1();
        public List<Item> GetList()
        {
            return appsOrder_Seat1;
        }
        private void Pork_Nachos_Click(object sender, EventArgs e)
        {

            appName = "Pork Nachos";
            appCost = 8.50;
            appsOrder_Seat1.Add(new Item { Name = appName, Price = appCost });
            appsTotal.Add(appCost);
            

        }

        private void Catfish_Bites_Click(object sender, EventArgs e)
        {
            appName = "Catfish Bites";
            appCost = 6.50;
            appsOrder_Seat1.Add(new Item { Name = appName, Price = appCost });
            appsTotal.Add(appCost);

        }

        private void Chicken_Nachos_Click(object sender, EventArgs e)
        {
            appName = "Chicken Nachos";
            appCost = 8.50;
            appsOrder_Seat1.Add(new Item { Name = appName, Price = appCost });
            appsTotal.Add(appCost);

            
        }

        private void Fried_Veggies_Click(object sender, EventArgs e)
        {
            appName = "Fried Veggies";
            appCost = 6.50;
            appsOrder_Seat1.Add(new Item { Name = appName, Price = appCost });
            appsTotal.Add(appCost);
        }

        private void Apps_Finished_Click(object sender, EventArgs e)
        {
            
            //table1.Show();
            this.Close();
        }
    }
    


}
