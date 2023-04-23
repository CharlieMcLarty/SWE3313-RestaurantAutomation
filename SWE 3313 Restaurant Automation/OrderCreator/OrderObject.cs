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
        int paymentInfo;
        int totalPrice;
        int seat;
        List<MenuItem> items;

        public OrderObject()
        {
            totalPrice = 0;
            items = new List<MenuItem>();
        }
    }
}
