using System;
using System.Text;
namespace dotnet_count_student_pass
{
    class SinhVienThiDo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhập số lượng sinh viên:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Không được quá 30 sinh viên");

            } while (size > 30);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Nhập điểm cho sinh viên thứ " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            int count = 0;
            Console.WriteLine("Danh sách điểm: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10)
                    count++;
            }
            Console.WriteLine("\nSố sinh viên vượt qua kì thi " + count);


        }
    }
}