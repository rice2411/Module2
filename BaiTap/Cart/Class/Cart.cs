using System;
using System.Collections.Generic;
using System.Text;

namespace Cart.Class
{
    class Carts
    {
        public bool status { get; set; }
        public List<Products> products { get; set; }
        public int total { get; set; }

        public int ToTal()
        { 
            foreach(var item in products)
            {
                total += item.amount * item.price;
            }
            return total;
        }
    }
}
