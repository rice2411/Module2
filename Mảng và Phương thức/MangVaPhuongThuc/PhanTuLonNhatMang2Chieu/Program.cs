using System;
using System.Text;
namespace PhanTuLonNhatMang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[,] arr =
            {
                {1,2,3,4,5 },
                {5,4,3,2,1 }
            };
            int max = arr[0, 0];
            for(int i =0; i<arr.GetLength(0);i++)
            {
                for(int j =0; j<arr.GetLength(1);j++)
                {
                    if(arr[i,j]>max)
                    {
                        max = arr[i, j];
                    }    
                }    
            }
            Console.WriteLine("Phần tử lớn nhất trong mảng là: {0}",max);
        }
    }
}
