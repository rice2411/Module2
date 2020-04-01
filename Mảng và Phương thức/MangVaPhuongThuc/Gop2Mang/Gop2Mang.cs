using System;
using System.Text;
namespace Gop2Mang
{
    class Gop2Mang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 6, 7, 8, 9, 10 };
            string arr3 ="";
            arr.ToString();
            arr2.ToString();
            Console.WriteLine("Mảng 1 là: [{0}]", string.Join(",", arr));
            Console.WriteLine("Mảng 2 là: [{0}]", string.Join(",", arr2));
            for (int i = 0; i < arr.Length; i++)
            {
                arr3 += arr[i]+",";
            }
            for(int i =0; i<arr2.Length;i++)
            {
                if(i==arr2.Length-1)
                {
                    arr3 += arr2[i];
                }
                else

                {
                    arr3 += arr2[i] + ",";
                }

            }
            Console.WriteLine("Sau khi gộp 2 mảng: [{0}]", arr3);
        }
    }
}
