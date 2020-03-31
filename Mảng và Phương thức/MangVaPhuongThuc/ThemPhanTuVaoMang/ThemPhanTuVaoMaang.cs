using System;
using System.Text;
namespace ThemPhanTuVaoMang
{
    class ThemPhanTuVaoMaang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr = { 1, 2, 3, 4, 5 };
            int add,index,temp=0;
            string result = "";
            Console.WriteLine("Nhập giá trị bạn muốn thêm vào mảng: ");
            add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vị trí bạn muốn thêm vào mảng: ");
            index = Convert.ToInt32(Console.ReadLine());
            while (index <= 0  || index >= arr.Length - 1) 
            { 
            Console.WriteLine("Vị trí phải lớn hơn 0 và nhỏ hơn {0}: ",arr.Length);
                index = Convert.ToInt32(Console.ReadLine());
            }
            arr.ToString();
            add.ToString();
            for(int i = 0; i<arr.Length;i++)
            {
                if(index==i)
                {
                   for(int a = 0; a<i;a++)
                    {
                        result += arr[a];
                        temp = arr[i];
                    }

                    result += add;
                    result += temp;
                    for (int b =i+1; b<arr.Length;b++)
                    {
                    
                        result += arr[b];
                    }    
                }    
            }
            Console.WriteLine("Mảng sau khi thêm là: {0}", result);
        }
    }
}
