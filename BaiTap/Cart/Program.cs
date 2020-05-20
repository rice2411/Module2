using System;
using Cart.Service;
namespace Cart
{
    class Program
    {
        public static  string  path = @"D:\CodeGym\Module2\Baitap\BaiTap\Cart\Data\Store.json";
        public static string output = @"D:\CodeGym\Module2\Baitap\BaiTap\Cart\Data\cart.json";
        public static string outputbill = $@"D:\CodeGym\Module2\Baitap\BaiTap\Cart\Data\Bill_{DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss_tt")}";
        public static JsonService js = new JsonService(path, output, outputbill);
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
                Console.WriteLine("--------------Cart------------");
                Console.WriteLine("1. Update Product");
                Console.WriteLine("2. Print Bill");
                Console.WriteLine("3. RemoveCart ");
                Console.WriteLine("4. Details Cart");
                Console.WriteLine("5. Exit");
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

                    Console.Write("Input name of Product: ");
                    string name = Console.ReadLine();
                    Console.Write("Input amount: ");
                    int amount = int.Parse(Console.ReadLine());
                    js.EditProduct(name, amount);
                    js.WriteJson();
                    break;
                case 2:
                    if(js.CreateBill())
                    {
                        js.WriteJson();
                        Console.WriteLine("Success");
                        js.RemoveCart();
                    } else
                    {
                        Console.WriteLine("out of order");
                    }


                    break;
                case 3:
                    js.RemoveCart();
                    js.WriteJson();
                    break;
                case 4:
                    js.Deital();
                    js.WriteJson();
                    break;
                case 5:
                    Environment.Exit(Environment.ExitCode);
                    break;
                

            }
           
            Menu();
        }
    }
}
