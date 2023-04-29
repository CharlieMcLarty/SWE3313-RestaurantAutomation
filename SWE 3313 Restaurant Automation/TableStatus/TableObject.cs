using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal class TableObject
    {
        static int TableCount = 0;
        private int TableID;
        /// Can be "clean" "full" or "dirty
        public Color Status;
        public OrderObject Order;


        public TableObject()
        {
            TableID = ++TableCount;
            Status = Color.Green;
        }

        public Color GetStatus()
        {
            return Status;
        }

        public void CreateOrder()
        {
            Order = new OrderObject(TableID, LoginPage.currentWaiter.getEmployeeID());
        }

        public int GetTableID()
        {
            return TableID;
        }

    }
}
