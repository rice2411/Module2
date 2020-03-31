using System;
using System.Text;
namespace HienThiCacLoaiHinh
{
    class HienThiCacLoaiHinh
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1. Vẽ hình chữ nhật");
                Console.WriteLine("2. Vẽ hình tam giác");
                Console.WriteLine("3. Vẽ hình tam giác cân ");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int size = 10;
                        int row = 0;
                        int col = 0;
                        Console.WriteLine("Vẽ hình chữ nhật");
                        for(row=0;row<4;row++)
                        {
                            if(row==0 || row ==3)
                            {
                                for(col=0; col<size;col++)
                                {
                                    Console.Write("*");
                                }    
                            } else
                            {
                                for(col=0; col<size;col++)
                                {
                                    Console.Write("*");
                                }    
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        choice = 0;
                        int choice2 = -1;
                       while(choice2!=0)
                        {
                            Console.WriteLine("1. Vẽ hình tam giác vuông ở góc trên trái");
                            Console.WriteLine("2. Vẽ hình tam giác vuông ở góc trên phải");
                            Console.WriteLine("3. Vẽ hình tam giác vuông ở góc dưới trái ");
                            Console.WriteLine("4. Vẽ hình tam giác vuông ở góc dưới phải");
                            Console.WriteLine("5. Exit");
                            Console.WriteLine("Nhập lựa chọn của bạn: ");
                            choice2 = Convert.ToInt32(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine("Vẽ hình tam giác vuông ở góc trên trái");
                                    int s = 5;
                                    int r = 0;
                                    int c = 0;
                                    for (r = 0; r < s; r++)
                                    {
                                        for (c = s; c > r; c--)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine("");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Vẽ hình tam giác vuông ở góc trên phải");
                                    int s1 = 5;
                                    int r1 = 0;
                                    int c1 = 0;
                                    int a = 0;
                                    for (r1 = 0; r1 < s1; r1++)
                                    {
                                        for (c1 = 0; c1 < s1; c1++)
                                        {
                                            if (c1 >= a && c1 <= 4)
                                            {
                                                Console.Write("*");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        a++;
                                        Console.WriteLine("");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine(" Vẽ hình tam giác vuông ở góc dưới trái ");
                                    int s2 = 5;
                                    int r2 = 0;
                                    int c2 = 0;
                                    for (r2 = 0; r2 < s2; r2++)
                                    {
                                        for (c2 = 0; c2 < r2 + 1; c2++)
                                        {
                                            Console.Write("*");
                                        }
                                        Console.WriteLine("");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine(" Vẽ hình tam giác vuông ở góc dưới phải");
                                    int s3 = 5;
                                    int r3 = 0;
                                    int c3 = 0;
                                    int a1 = 4;
                                    for (r3 = 0; r3 < s3; r3++)
                                    {
                                        for (c3 = 0; c3 < s3; c3++)
                                        {
                                            if (c3 >= 0 && c3 < a1)
                                            {
                                                Console.Write(" ");
                                            }
                                            else
                                            {
                                                Console.Write("*");
                                            }

                                        }
                                        a1--;
                                        Console.WriteLine("");
                                    }

                                    break;
                                case 5:
                                    Console.WriteLine("Exit");
                                    choice = -1;
                                    choice2 = 0;
                                    break;
                            }
                        }    
                        break;
                    case 3:
                        Console.WriteLine("Vẽ hình tam giác cân ");
                        int row3 = 0;
                        int col3 = 0;
                        int x = 1;
                        int y = 25;
                        for (row3=0; row3 < 20; row3++)
                        {
                            for (col3 = 1; col3 < 26; col3++)
                            {
                                if (col3 <= x && col3 >= y)
                                {
                                    Console.Write('*');
                            }
                                else
                                {
                                    Console.Write(" ");
                              }
                            }
                            x++;
                             y--;


                         Console.WriteLine("");
                                }
                        break;
                    case 4:
                        Console.WriteLine("EXIT");
                        Console.WriteLine("Nhấn phím bất kì để thoát");
                        choice = 0;
                        break;
                }    
            }
        }
    }
}
