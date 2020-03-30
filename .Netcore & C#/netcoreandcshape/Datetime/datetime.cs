using System;
using System.Text;
namespace Datetime
{
    class dateandtime
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Bây giờ là: {0}", localDate);
        }
    }
}
