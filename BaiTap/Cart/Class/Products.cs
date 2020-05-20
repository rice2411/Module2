using System;
using System.Collections.Generic;
using System.Text;

namespace Cart.Class
{
    class Products
    {
        public string name { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public int money { get; set; }
        public  int Money()
        {
            return money = price * amount;
        }
    }
}
