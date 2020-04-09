using System;
using System.Text;
namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int num;
            Console.WriteLine("Nhập vào độ dài của mảng: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int [num,num];
            Random r = new Random();
            for(int i =0;i<num;i++)
            {
                for(int j =0;j<num;j++)
                {
                    arr[i, j] = r.Next(10, 90);
                }    
            }
            Menu(arr);
          



        }
        public static void Menu(int [,] arr)
        {
           
            int choice = -1;
            while (choice <1 || choice > 8)
            {
                Console.WriteLine("1. Tính tổng các số chẵn trong ma trận");
                Console.WriteLine("2. Tính tổng các giá trị trên đường chéo chính");
                Console.WriteLine("3. Tính tổng các giá trị trên đường chéo phụ");
                Console.WriteLine("4. Tính tổng các giá trị trên đường biên");
                Console.WriteLine("5. Hiển thị ma trận");
                Console.WriteLine("6. Hiển trị ma trận tam giác dưới");
                Console.WriteLine("7. Hiển thị ma trân tam giác trên");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice, arr);
                Console.WriteLine();
                choice = -1;
            }
            
        }
        public static void Choice(int choice, int[,] arr)
        {
            switch(choice)
            {
                case 1:
                    int sumEven = 0;

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                           if(arr[i,j]%2==0)
                            {
                                sumEven += arr[i, j];
                            }    

                        }
                    
                    }
                    Console.WriteLine("Tổng các số chắn là: {0}", sumEven);
                    break;
                case 2:
                    int sum = 0;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                           if(i==j)
                            {
                                sum += arr[i , j ];
                            }    

                        }

                    }
                    Console.WriteLine("Tổng các số trên đường chéo chính là : {0}", sum);
                    break;
                case 3:
                    int sum1 = 0;
                    int m = arr.GetLength(0);
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        m--;
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (j==m)
                            {
                                sum1 += arr[i, j];
                            }

                        }

                    }
                    Console.WriteLine("Tổng các số trên đường chéo phụ là : {0}", sum1);
                    break;
                case 4:
                    int sum3 = 0;
                    int c = arr.GetLength(0) - 1;
                   for(int j = 0; j < arr.GetLength(0); j++)
                    {
                        sum3 += arr[0, j];
             
                    }
             
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        sum3 += arr[arr.GetLength(0) - 1, j];
                        
                    }
                  
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        if(i!=0 && i != arr.GetLength(0)-1)
                        {
                            sum3 += arr[i, 0];
                        }    
                       
                    }
            
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        if (i != 0 && i != arr.GetLength(0) - 1)
                        {
                            sum3 += arr[i, arr.GetLength(0) - 1];
                        }

                    }
                    Console.WriteLine("Tổng đường chéo các biên là: {0}",sum3);

                    break;
                case 5:
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            Console.Write("{0,1} ", arr[i, j]);

                        }
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (i >= j)
                            {
                                Console.Write("{0} ", arr[i, j]);
                            } else
                            {
                                Console.Write("{0}  ",0);
                            }    

                        }
                        Console.WriteLine();
                    }

                    break;
                case 7:
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (i <= j)
                            {
                                Console.Write("{0} ", arr[i, j]);
                            }
                            else
                            {
                                Console.Write("{0}  ", 0);
                            }

                        }
                        Console.WriteLine();
                    }

                    break;
                case 8:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            
        }
    }
}
