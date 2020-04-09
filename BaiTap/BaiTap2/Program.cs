using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int num;
            Console.WriteLine("Nhập vào độ dài của mảng: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[num, num];
            int[,] arr1 = new int[num, num];
            int[,] arr2 = new int[num, num];
            int[,] arr3 = new int[num, num];
            random(arr);
            random(arr1);
            for (int  i =0; i < num;i++)
            {
                for(int j =0; j < num;j++)
                {
                    arr2[i, j] = arr[i, j] + arr1[i, j];
                    arr3[i, j] = arr[i, j] * arr1[i, j];
                }
            }
            Console.WriteLine("Mảng 1 là: ");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0,1} ", arr[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("Mảng 2 là: ");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0,1} ", arr1[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("Tổng 2 mảng là: ");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0,1} ", arr2[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("Tích 2 mảng là: ");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0,1} ", arr3[i, j]);

                }
                Console.WriteLine();
            }
            
        }
        public static void random(int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = r.Next(10, 40);
                }
            }
        }
    }
}
