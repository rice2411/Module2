using System;

namespace SoThanhChu
{
    class SoThanhChu
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(trans(number));
        }
        public static string trans(int num)
        {
            if(num<=10 && num>=0)
            {
                switch (num)
                {
                    case 0:
                        return "zero";
                        break;
                    case 1:
                        return "one";
                        break;
                    case 2:
                        return "two";
                        break;
                    case 3:
                        return "three";
                        break;
                    case 4:
                        return "four";
                        break;
                    case 5:
                        return "five";
                        break;
                    case 6:
                        return "six";
                        break;
                    case 7:
                        return "seven";
                        break;
                    case 8:
                        return "eight";
                        break;
                    case 9:
                        return "nine";
                        break;
                    case 10:
                        return "ten";
                        break;
                }
            }
            else if(num>10 && num<=20)
                {
                    int a = num % 10;
                    switch (a)
                    {
                        case 0:
                            return "twenty";
                            break;
                        case 1:
                            return "eleven";
                            break;
                        case 2:
                            return "twelve";
                            break;
                        case 3:
                            return "thirteen";
                            break;
                        case 4:
                            return "fourteen";
                            break;
                        case 5:
                            return "fiftine";
                            break;
                        case 6:
                            return "sixtine";
                            break;
                        case 7:
                            return "seventine";
                            break;
                        case 8:
                            return "eighttine";
                            break;
                        case 9:
                            return "ninetine";
                            break;
                    }    
                }    
           else if(num>20 && num <100)
            {
                int a = num / 10;
                int b = num % 10;
                string rs = "";
                switch (a)
                {
          
                    case 2:
                        rs += "twenty ";
                        break;
                    case 3:
                        rs += "thirty ";
                        break;
                    case 4:
                        rs += "fourty ";
                        break;
                    case 5:
                        rs += "fifty ";
                        break;
                    case 6:
                        rs += "sixty ";
                        break;
                    case 7:
                        rs += "seventy ";
                        break;
                    case 8:
                        rs += "eighty ";
                        break;
                    case 9:
                        rs += "ninety ";
                        break;
                }    
                switch (b)
                {
            
                    case 1:
                        rs += "one";
                        break;
                    case 2:
                        rs += "two";
                        break;
                    case 3:
                        rs += "three";
                        break;
                    case 4:
                        rs += "four";
                        break;
                    case 5:
                        rs += "five";
                        break;
                    case 6:
                        rs += "six";
                        break;
                    case 7:
                        rs += "seven";
                        break;
                    case 8:
                        rs += "eight";
                        break;
                    case 9:
                        rs += "nine";
                        break;
                }
                return rs;
            } else if (num>=100 && num <=999)
            {
                int d = num / 100;
                int c = num % 100;
                int a = c / 10;
                int b = c % 10;
                string rs = "";
                switch(d)
                {
                    case 1:
                        rs += "one hundred ";
                        break;
                    case 2:
                        rs += "two hundred ";
                        break;
                    case 3:
                        rs += "three hundred ";
                        break;
                    case 4:
                        rs += "one hundred ";
                        break;
                    case 5:
                        rs += "five hundred";
                        break;
                    case 6:
                        rs += "six hundred ";
                        break;
                    case 7:
                        rs += "seven hundred ";
;                       break;
                    case 8:
                        rs += "eight hundred ";
                        break;
                    case 9:
                        rs += "nine hundred ";
                        break;
                }    
                switch (a)
                {
                    case 1:
                        rs += "ten";
                        break;
                    case 2:
                        rs += "twenty ";
                        break;
                    case 3:
                        rs += "thirty ";
                        break;
                    case 4:
                        rs += "fourty ";
                        break;
                    case 5:
                        rs += "fifty ";
                        break;
                    case 6:
                        rs += "sixty ";
                        break;
                    case 7:
                        rs += "seventy ";
                        break;
                    case 8:
                        rs += "eighty ";
                        break;
                    case 9:
                        rs += "ninety ";
                        break;
                }
                switch (b)
                {

                    case 1:
                        rs += "one";
                        break;
                    case 2:
                        rs += "two";
                        break;
                    case 3:
                        rs += "three";
                        break;
                    case 4:
                        rs += "four";
                        break;
                    case 5:
                        rs += "five";
                        break;
                    case 6:
                        rs += "six";
                        break;
                    case 7:
                        rs += "seven";
                        break;
                    case 8:
                        rs += "eight";
                        break;
                    case 9:
                        rs += "nine";
                        break;
                }
                return rs;
            }    
            return "out of ability";
        }
    }
}
