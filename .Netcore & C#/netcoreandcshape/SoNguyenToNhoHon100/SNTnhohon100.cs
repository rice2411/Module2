using System;
using System.Text;
namespace SoNguyenToNhoHon100
{
    class SNTnhohon100
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int dem = 0;
            Console.WriteLine("100 số nguyên tố đầu tiên là :");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                if (dem == 2)
                {
                    Console.WriteLine(i);
                }
                dem = 0;
            }
        }
    }
}
