using System;
using System.Text;
namespace TinhTongMotCoi
{
    class TinhTongMotCot
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int sum=0;
            int[,] arr =
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 }
            };
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.WriteLine("Phần tử [{0},{1}] của mảng là, {2}", i, j, arr[i, j]);
            for (int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i,0];
            Console.WriteLine("Tổng phần tử cột đầu tiên là: {0}", sum);
        }
    }
}
