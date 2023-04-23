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
        List<OrderObject> CurrentOrders;


        public TableObject()
        {
            TableID = ++TableCount;
            Status = Color.Green;
            CurrentOrders = new List<OrderObject>();
        }

        public Color GetStatus()
        {
            return Status;
        }

        public int GetTableID()
        {
            return TableID;
        }

        public void CreateOrder()
        {
            CurrentOrders.Add(new OrderObject(TableID));
        }
    }
}
