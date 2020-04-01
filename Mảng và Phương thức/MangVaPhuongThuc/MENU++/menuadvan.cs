using System;
using System.Text;
using System.Collections.Generic;
namespace MENU__
{
    class menuadvan
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            CreateMenu();

        }
        public static void CreateMenu()
        {
            int choice=-1;

            while (choice<1 || choice >4)
            {
                Console.WriteLine("1. Tạo mảng gồm 20 phần tử ngẫu nhiên");
                Console.WriteLine("2. Tạo mảng gồm 30 phần tử ngẫu nhiên");
                Console.WriteLine("3. Tạo mảng gồm 40 phần tử ngẫu nhiên");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());

           
              
            }    
            CreateArray(choice);
        }
        public static void CreateArray(int opt)
        {
            switch(opt)
            {
                case 1:
                    int[] arr = new int[20];
                    Random r = new Random();
                    for(int i =0; i<arr.Length;i++)
                    {
                        arr[i] = r.Next(10, 50);
                    }
                    option(arr);

                    break;
                case 2:
                    int[] arr2 = new int[30];
                    Random r2 = new Random();
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        arr2[i] = r2.Next(10, 50);
                    }
                    option(arr2);

                    break;
                case 3:
                    int[] arr3 = new int[40];
                    Random r3 = new Random();
                    for (int i = 0; i < arr3.Length; i++)
                    {
                        arr3[i] = r3.Next(10, 50);
                    }
                    option(arr3);
                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }    
        }
        public static void option(int[] array)
        {
            int choice = -1;

            while (choice !=0)
            {
                Console.WriteLine("1. Hiển thị mảng");
                Console.WriteLine("2. Hiển thị tổng các phần tử của mảng");
                Console.WriteLine("3. Hiển thị số chẵn");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                action(choice, array);
            }
          
        }
        public static void action (int op,int[] array)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine("Mảng của bạn là: [{0}]", string.Join(",", array));
                    break;
                case 2:
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                        sum += array[i];
                    Console.WriteLine("Tổng các phần tử của mảng là: {0}", sum);
                    break;
                case 3:
                    string even="";
                    for(int i =0; i<array.Length;i++)
                    {
                        if(array[i]%2==0)
                        {
                            even += array[i].ToString()+" ";
                        }    
                    }
                   
                    Console.WriteLine("Các số chắn trong mảng là: [{0}]", even);
                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode); 
                    break;
            }    

        }
             
    }
}
