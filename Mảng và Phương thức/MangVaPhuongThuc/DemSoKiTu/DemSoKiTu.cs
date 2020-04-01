using System;
using System.Text;
namespace DemSoKiTu
{
    class DemSoKiTu
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string name = "Tôn Thât Anh Minh";
            int count = 0;
            for(int i=0;i<name.Length;i++)
            {
                if(name[i]==' ')
                {
                    continue;
                }    
                else
                {
                    count++;
                }    
            }
            Console.WriteLine("Chuỗi là: {0}", name);
            Console.WriteLine("Số kí tự trong chuỗi là: {0}", count);
        }
    }
}
