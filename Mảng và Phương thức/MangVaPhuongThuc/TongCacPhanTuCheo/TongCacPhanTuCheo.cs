using System;
using System.Text;
namespace TongCacPhanTuCheo
{
    class TongCacPhanTuCheo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {     
                    Console.WriteLine("Nhập giá tị cho phần tử [{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Tổng các phần tử ở đường chéo chính là: {0}", caculator(arr));
        }
        public static int caculator(int [,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)

                sum += arr[i, i];
            return sum;
        }
    }
}
