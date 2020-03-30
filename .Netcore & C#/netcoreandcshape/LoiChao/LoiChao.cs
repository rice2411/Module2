using System;
using System.Text;
namespace LoiChao
{
    class LoiChao
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string name;
            Console.WriteLine("Nhập tên của bạn: ");
            name = Console.ReadLine();
            Console.WriteLine("Xin chào {0}", name);
        }
    }
}
