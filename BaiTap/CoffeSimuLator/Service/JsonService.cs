using CoffeSimuLator.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using CoffeSimuLator.Payload;

namespace CoffeSimuLator.Service
{
    class JsonService
    {
        private Bill bill;
        private PayLoadMenu menu;
        private PayLoadTable tables;

        private string inputmenu;
        private string outputbill;
        private string usingtable;
     
        public JsonService(string inputmenu, string outputbill,string usingtable)
        {
            this.inputmenu = inputmenu;
            this.usingtable = usingtable;
            this.outputbill = outputbill;
            tables = new PayLoadTable()
            {
                tables = new List<Table>()
            };
        }
        public void ReadJsonTable()
        {
            using (
               StreamReader sr = File.OpenText(this.usingtable))
            {
                var obj = sr.ReadToEnd();
                tables = JsonConvert.DeserializeObject<PayLoadTable>(obj);
            }
        }
        public void ReadJson()
        {
            menu = new PayLoadMenu();
            using (StreamReader sr = File.OpenText(this.inputmenu))
            {
                var obj = sr.ReadToEnd();
                menu = JsonConvert.DeserializeObject<PayLoadMenu>(obj);
            }
           
        }
        public void WriteJSon()
        {      
            using (StreamWriter sw = File.CreateText(this.usingtable))
            {
                var data = JsonConvert.SerializeObject(tables);

                sw.Write(data);
            }
        }
        public void PrintBillJSOn()
        {

            using (StreamWriter sw = File.CreateText(this.outputbill))
            {
                var data = JsonConvert.SerializeObject(bill);

                sw.Write(data);
            }
        }
        public void AddTable(int id )
        {

            
            Order order = new Order();
            if (!tables.CheckTable(id))
            {

                Table table = new Table();
                table.id = id;
                table.status = true;
                table.timeIn = DateTime.Now;
                tables.tables.Add(table);
               
                do
                {
                    Console.Write("Input order :");
                    order.name = Console.ReadLine();
                    Console.Write("Amount: ");
                    order.amout = int.Parse(Console.ReadLine());
                   
                  


                } while (!ValidOrder(order.name));
         

                foreach (var item in menu.menu)
                {
                    if (item.name.ToLower().Equals(order.name.ToLower()))
                    {
                        order.price = item.price;
                    }
                }
                table.ordersDetails = new List<Order>();
                table.ordersDetails.Add(order);
            }  
            else
            {
                UpdateOrder(id,order);
            }

            
        }
        public void UpdateOrder(int id, Order order)
        {

                 
                do
                {
                Console.Write("Input order :");
                order.name = Console.ReadLine();
                Console.Write("Amount: ");
                order.amout = int.Parse(Console.ReadLine());
              


            } while (!ValidOrder(order.name));

           
                foreach (var item in menu.menu)
                {
                    if (item.name.ToLower().Equals(order.name.ToLower()))
                    {
                        order.price = item.price;
                    }
                }
          
                tables.tables[id - 1].ordersDetails.Add(order);
           
        }
        public bool PrintBill(int id)
        {
           
            if (tables.CheckTable(id))
            {
                bill = new Bill();
                bill.id = tables.tables[id - 1].id;
                bill.timeIn = tables.tables[id - 1].timeIn;
                bill.timeOut = DateTime.Now;
                bill.total = tables.tables[id-1].Total(id);
                bill.ToString();
                bill.note = new List<Note>();
             
                foreach(var item in tables.tables[id-1].ordersDetails)
                {
                    Note note = new Note();
                    note.name = item.name;
                    note.amout = item.amout;
                    note.price = item.price * note.amout;
                    bill.note.Add(note);
                }
             
                tables.tables.RemoveAt(id - 1);
                return true;
            }
            return false;
        }
       
     public bool ValidOrder(string name)
        {
            foreach (var item in menu.menu)
            {
                if (item.name.ToLower().Equals(name.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }


}
