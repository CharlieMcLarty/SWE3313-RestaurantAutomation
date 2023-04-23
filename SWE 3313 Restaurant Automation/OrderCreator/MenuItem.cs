using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal class MenuItem
    {
        String name;
        String category;
        int price;
        int inventory;
        int timesOrdered;

        public MenuItem(String name, int price, String category)
        {
            this.price = price;
            this.name = name;
            this.category = category;
            inventory = 100;
            timesOrdered = 0;
        }
    }
}
