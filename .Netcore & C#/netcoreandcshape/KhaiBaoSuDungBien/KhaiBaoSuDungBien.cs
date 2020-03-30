using System;
using System.Text;
namespace KhaiBaoSuDungBien
{
    class KhaiBaoSuDungBien
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int i = 10;
            float f = 20.5f;
            double d = 20.5;
            Boolean b = true;
            char c = 'a';
            String s = "CodeGym";
            Console.WriteLine("Giá trị của biến i là " + i);
            Console.WriteLine("Giá trị của biến f là " + f);
            Console.WriteLine("Giá trị của biến d là " + d);
            Console.WriteLine("Giá trị của biến b là " + b);
            Console.WriteLine("Giá trị của biến c là " + c);
            Console.WriteLine("Giá trị của biến i là " + s);
        }
    }
}