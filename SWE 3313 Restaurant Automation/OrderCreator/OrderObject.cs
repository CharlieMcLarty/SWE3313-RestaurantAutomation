using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal class OrderObject
    {
        //int TimeToFinish;  may add
        static int orderCount;
        int orderID;
        int paymentInfo;
        double totalPrice;
        int seat;
        int TableID;
        int waiterID;
        public List<MenuItem> items;


        public OrderObject(int TableID, int waiterID)
        {
            orderID = ++orderCount;
            this.TableID = TableID;
            this.waiterID = waiterID;
            totalPrice = 0;
            items = new List<MenuItem>();
        }
        public int getTableID()
        {
            return TableID;
        }
        public int getWaiterID()
        {
            return waiterID;
        }
        public void addToOrder(MenuItem menuItem)
        {
            items.Add(menuItem);
            totalPrice += menuItem.price;
        }
        public double getTotalPrice()
        {
            return totalPrice;
        }
    }
}
