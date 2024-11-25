using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sql_Server
{
    internal class OrderedItem
    {
        public OrderedItem(int pID, int qty, double price)
        {
            PID = pID;
            Qty = qty;
            Price = price;
        }

        public int PID { get; set; }
        public int Qty { get; set; }

        public double Price { get; set; }
    }
}
