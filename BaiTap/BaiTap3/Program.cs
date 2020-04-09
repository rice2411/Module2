using System;
using System.Text;
namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int num,num1;
            Console.WriteLine("Nhập vào chiều dài của mảng: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều rộng của mảng: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[num, num1];
            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    arr[i, j] = r.Next(20, 60);
                }
            }
            Menu(arr);
        }
        public static void Menu(int[,] arr)
        {
            int choice = -1;
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine("1. Hiển thị ma trận chỉ 1 giá trị");
                Console.WriteLine("2. Ma trận gồm các số là bội của 5");
                Console.WriteLine("3. Đảo ngược chiều dài chiều rộng");
                Console.WriteLine("4. Exit ");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice, arr);
                choice = -1;
            }
        }
        public static  void Choice(int choice, int[,] arr)
        {
            switch(choice)
            {
                case 1:
                    int num=0;
                    while( num<20 || num > 60)
                    {
                        Console.WriteLine("Nhập giá trị của bạn: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    }    
                    for(int i =0; i<arr.GetLength(0);i++)
                    {
                        for(int j =0;j<arr.GetLength(1);j++)
                        {
                            arr[i, j] = num;
                            
                        }    
                    }
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                           Console.Write("{0,1} ",arr[i,j]);

                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int num1 = 5;
                    int x = 1;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                           
                            arr[i, j] = num1 * x;
                            x++;
                            
                        }
                    }
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            Console.Write("{0,1} ", arr[i, j]);

                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    int[,] a = new int[arr.GetLength(1), arr.GetLength(0)];
                    Random r = new Random();
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            a[i, j] = r.Next(20, 60);
                        }
                    }
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            Console.Write("{0,1} ", a[i, j]);

                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Environment.Exit(Environment.ExitCode);

                    break;

            }    
        }
    }
}
