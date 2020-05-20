using Cart.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Cart.Service
{
    class JsonService
    {
        private Store stores;
        private Carts cart;
        private Bill bill;
        private string inputdata;
        private string outputdata;
        private string outputbill;
        public JsonService(string input, string output, string outputbill )
        {
            inputdata = input;
            outputdata = output;
            this.outputbill = outputbill;
            stores = new Store()
            {
                store = new List<Product>()
            };
            cart = new Carts()
            {
                products = new List<Products>()
            };
        }
        public void ReadJson()
        {
            using ( StreamReader sr = File.OpenText(inputdata))
            {
                var obj = sr.ReadToEnd();
                stores = JsonConvert.DeserializeObject<Store>(obj);
            }
        }
        public void WriteJson()
        {
            using (StreamWriter sw = File.CreateText(outputdata))
            {
                var data = JsonConvert.SerializeObject(cart);

                sw.Write(data);
            }
            using (StreamWriter sw = File.CreateText(inputdata))
            {
                var data = JsonConvert.SerializeObject(stores);

                sw.Write(data);
            }
            using (StreamWriter sw = File.CreateText(outputbill))
            {
                var data = JsonConvert.SerializeObject(bill);

                sw.Write(data);
            }
        }
        public void EditProduct(string name, int amout)
        {
            int pos = CheckProductInStore(name);
            if(pos>-1)
            {
                if ( CheckProductIncart(name) && amout >= 0)
                {
                    cart.products[0].amount += amout;
                    cart.products[0].money = cart.products[0].amount * cart.products[0].price;

                }
                else if (CheckProductIncart(name) && amout < 0)
                {
                    cart.products[0].amount += amout;
                    cart.products[0].money = cart.products[0].amount * cart.products[0].price;
                    if (cart.products[0].amount <= 0)
                    {
                        cart.products.RemoveAt(pos);
                    }
                    
                }
                else
                {
                    Products prd = new Products();
                    prd.name = name;
                    prd.price = stores.store[pos].price;
                    prd.amount = amout;
                    prd.Money();
                    cart.products.Add(prd);
                    cart.ToTal();
                }
            } else
            {
                Console.WriteLine("Invalid Product");
            }
         
        }
        public bool CreateBill()
        {
          if(CheckRemainProduct())
            {
                bill = new Bill()
                {
                    cart = new Carts()
                    {
                        status = true,
                        products = cart.products,
                        total = cart.total

                    },
                    paytime = DateTime.Now
                };
                for (int i = 0; i < bill.cart.products.Count; i++)
                {
                    for (int j = 0; j < stores.store.Count; j++)
                    {
                        if (bill.cart.products[i].name.ToLower().Equals(stores.store[j].name))
                        {
                            stores.store[j].remain -= bill.cart.products[i].amount;
                        }
                    }
                }
            
                return true;
            } 
            return false;
        }
        public void Deital()
        {
            Console.WriteLine("Your Cart:");
            Console.WriteLine($"Status:{ cart.status}");
            
            foreach(var item in cart.products)
            {
                Console.WriteLine($"Name:{item.name}\tPrice:{item.price}\tAmout:{item.amount}\tMoney:{item.money}");
            }
            Console.WriteLine($"Total: {cart.total}");
        }
        public void RemoveCart()
        {
            Console.WriteLine("Are you sure? (y to confirm or any key to quit)");
            string choice = Console.ReadLine().ToLower();
            if(choice == "y")
            {
                cart.status = false;
                for(int i =0; i < cart.products.Count;i++)
                {
                    cart.products.RemoveAt(i);
                }
                cart.total = 0;
            }
        }
        public bool CheckProductIncart(string name)
        {
            foreach(var item in cart.products)
            {
                if(name.ToLower().Equals(item.name))
                {
                    return true;
                }    
            }
            return false;
        }
        public int CheckProductInStore(string name)
            
        {
            for(int i =0; i < stores.store.Count;i++)
            {
                if (name.ToLower().Equals(stores.store[i].name))
                {
                    return i;
                }
            }
            return -1;
        }
        public int CheckProductInBill(string name)

        {
            for (int i = 0; i < bill.cart.products.Count; i++)
            {
                if (name.ToLower().Equals(bill.cart.products[i].name))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool CheckRemainProduct()
        {
            foreach(var item in stores.store)
            {
                if(item.remain==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
} 
