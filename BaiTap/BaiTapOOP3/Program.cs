using System;

namespace BaiTapOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            So number = new So();
            do
            {
                Console.WriteLine("Nhap he co so 2/8/16:");
                number.HCS = Console.ReadLine();
            } while (number.HCS != "2" && number.HCS != "8" && number.HCS != "16");
            switch(number.HCS)
            {
                case "2":
                        do
                        {
                            Console.WriteLine("Nhap Gia Tri: ");
                            number.GiaTri = Console.ReadLine();
                        } while (!ValiDate2(number.GiaTri));
                    Console.WriteLine(number.ConVert(number.GiaTri, number.HCS));
                    break;
                case "8":
                        do
                    {
                        Console.WriteLine("Nhap Gia Tri: ");
                        number.GiaTri = Console.ReadLine();
                    } while (!ValiDate8(number.GiaTri));
                    Console.WriteLine(number.ConVert(number.GiaTri, number.HCS));
                    break;
                case "16":
                    do
                    {
                        Console.WriteLine("Nhap Gia Tri: ");
                        number.GiaTri = Console.ReadLine();
                    } while (!ValiDate16(number.GiaTri));
                    Console.WriteLine(number.ConVert(number.GiaTri, number.HCS));
                    break;
            }
            
         
        }
        public static bool ValiDate2(string str)
        {
            
            for (int i =0; i<str.Length;i++)
            {
                if(str[i]!= '0' && str[i]!='1')
                {
                    return false;
                }
                if(Char.IsLetter(str[i]) == true)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValiDate8(string str)
        {
           
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt32(str[i]) < 0 && Convert.ToInt32(str[i]) > 7 )
                {
                    return false;
                }
                if (Char.IsLetter(str[i]) == true)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValiDate16(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if ( str[i]!= 'A' && str[i] != 'B' && str[i] != 'C' && str[i] != 'D' && str[i] != 'E' && str[i] != 'F' && Char.IsNumber(str[i])==false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
