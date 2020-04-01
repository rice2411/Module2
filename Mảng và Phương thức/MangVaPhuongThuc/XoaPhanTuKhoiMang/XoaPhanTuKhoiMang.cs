using System;
using System.Text;
using System.Collections.Generic;
namespace XoaPhanTuKhoiMang
{
    class XoaPhanTuKhoiMang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Mảng là: [{0}]", string.Join(",", arr));
            int rmv;
            string result = "";
            Console.WriteLine("Nhập vị trí bạn muốn xóa: ");
            rmv = Convert.ToInt32(Console.ReadLine());
            while(rmv<0 || rmv > arr.Length)
            {
                Console.WriteLine("Vị trí phải lớn hơn 0 và bé hơn {0}", arr.Length);
                rmv = Convert.ToInt32(Console.ReadLine());
            }
           for( int i =0; i<rmv;i++)
            {
                result += arr[i]+",";
            }    
           for(int j = rmv +1;j<arr.Length;j++)
            {
                if(j!=arr.Length-1)
                {
                    result += arr[j] + ",";
                }else
                {
                    result += arr[j];
                }    
            }
            Console.WriteLine("Mảng đã được thay đổi [{0}]", result);
        }
    }
}
