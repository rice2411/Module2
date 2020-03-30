using System;
using System.Text;
namespace menu
{
    class menu
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choice = -1;
            while(choice!=0)
            {
                Console.WriteLine("1. Vẽ hình vuông");
                Console.WriteLine("2. Vẽ hình chữ nhật");
                Console.WriteLine("3. Vẽ tam giác");
                Console.WriteLine("4. Bonus");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Vẽ hình vuông");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 2:
                        Console.WriteLine("Vẽ hình chữ nhật");
                        Console.WriteLine("**************");
                        Console.WriteLine("**************");
                        Console.WriteLine("**************");
                        Console.WriteLine("**************");
                        break;
                    case 3:
                        Console.WriteLine("Vẽ tam giác");
                        Console.WriteLine("*********");
                        Console.WriteLine("********");
                        Console.WriteLine("*******");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 4:
                        Console.WriteLine("Bonus");
                        Console.WriteLine("Minh đẹp trai :>");
                        break;
                    default:
                        {
                            Console.WriteLine("nothing to print");
                        }
                        break;
                }
            }
           
        }
    }
}
