using System;
using CoffeSimuLator.Service;
namespace CoffeSimuLator
{
    class Program
    {
        public static string menu = @"D:\CodeGym\Module2\Baitap\BaiTap\CoffeSimuLator\Data\Menu.json";
        public static string bill = $@"D:\CodeGym\Module2\Baitap\BaiTap\CoffeSimuLator\OutPutData\{DateTime.Now.ToString("hh_mm dd_MM_yyy")}";
        public static string usingtable = @"D:\CodeGym\Module2\Baitap\BaiTap\CoffeSimuLator\OutPutData\Table.json";
        public static JsonService js = new JsonService(menu, bill, usingtable);
        static void Main(string[] args)
        {
            js.ReadJson();
            Menu();
     
        }
        public static void Menu()
        {
            int choice = -1;
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("--------------RCAFE------------");
                Console.WriteLine("1. New Table");
                Console.WriteLine("2. Print Bill");
                Console.WriteLine("3. Exit: ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Input your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice);

            }
        }
        public static void Choice(int choice)
        {

            switch (choice)
            {
                case 1:
       
                    Console.Write("Input number of table: ");
                    int id = int.Parse(Console.ReadLine());
                    js.AddTable(id);
                    js.WriteJSon();
                    js.ReadJsonTable();
                    Console.Clear();
                    Console.WriteLine("Check your data file");
                    break;
                case 2:
             
                    Console.Write("Input number of table: ");
                    int id1 = int.Parse(Console.ReadLine());
                    js.ReadJsonTable();
                    if(js.PrintBill(id1))
                    { 
                        js.PrintBillJSOn();
                        js.WriteJSon();
                        Console.Clear();
                        Console.WriteLine("Check your data file");
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid table");
                    }
              
                    break;
                case 3:
                    Environment.Exit(Environment.ExitCode);
                    break;
             
            }
          
            Menu();
        }
    }
}
