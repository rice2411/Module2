using System;
using System.Text;
namespace Dientichhinhchnhat
{
    class dientichhcn
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            float width, length;
            Console.WriteLine("Nhập chiều dài: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diện tích hình chữ nhật là: {0}", area(width, length));
        }
        public static float area(float wid, float len)
        {
            return wid * len;
        }
    }
}
