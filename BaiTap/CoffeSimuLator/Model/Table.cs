using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSimuLator.Model
{
    class Table
    {
        public int id { get; set; }
        public bool status { get; set; }
        public DateTime timeIn { get; set; }
        public List<Order> ordersDetails { get; set; }
        public int Total(int id)
        {
            int total = 0;
            foreach (var money in ordersDetails)
            {
                total += money.price*money.amout;
            }
            return total;
        }
       
    }
}
