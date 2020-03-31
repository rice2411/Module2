using System;
using System.Text;
namespace dotnet_Findmin
{
    class GiaTriNhoNhatCuaMang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhập độ dài mảng:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Mảng không được dài quá 20");
            } while (size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Nhập giá trị thứ:" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Danh sách các giá trị: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            int min = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine("Giá trị nhỏ nhất của mảng là " + min + " ,tại vị trí " + index);
        }
    }
}