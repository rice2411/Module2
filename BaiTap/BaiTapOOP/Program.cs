using System;
using System.Text;
namespace BaiTapOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Employee[] arr = new Employee[1];
         
            Menu(arr);

        }
        public  static void Menu(Employee[] arr)
        {
            int choice = -1;
            while(choice<1 || choice >4)
            {
                Console.WriteLine("--------------RSTORE------------");
                Console.WriteLine("1. Tạo danh sách Employees");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Tìm kiếm Employees theo tên: ");
                Console.WriteLine("4. Exit");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice,arr);
                
            }    
        }
        public static void Choice(int choice, Employee[] arr)
        {
            
            switch (choice)
            {
                case 1:
                    string choicee = "";
                    int a = 1;
                    int b = 0;
                    do
                    {
                        if(choicee!="")
                        {
                            Array.Resize(ref arr, a=a+1);
                        }
                        CreateArray(arr,b);
                        b++;
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục nhập Employeer hoặc 0 để hủy: ");
                        choicee = Console.ReadLine();
                    }
                    while (choicee != "0");
                    Menu(arr);
                   
                    break;
                case 2:
                    ShowArray(arr);
                    Menu(arr);
                    break;
                case 3:
                    string name = "";
                    Console.WriteLine("Nhập tên Employee bạn muốn tìm: ");
                    name = Console.ReadLine().ToLower();
                    findEmp(arr, name);
                    Menu(arr);
                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }    
        }
        public static void CreateArray(Employee[] arr,int i)
        {
           
            for (int j = i; j<arr.Length; j++)
            {
                    arr[j] = new Employee();
                     Console.WriteLine("Nhập tên: ");
                    arr[j].name = Console.ReadLine();
                    arr[j].setDob();
                    Console.WriteLine("Nhâp email: ");
                    arr[j].email = Console.ReadLine();
                    Console.WriteLine("Nhập địa chỉ: ");
                    arr[j].address = Console.ReadLine();
            }
        }
        public static void ShowArray(Employee[] arr)
        {
            for(int i =0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i].showInfo());
                Console.WriteLine();
            }    
        }
        public static void findEmp(Employee[] arr, string name)
        {
            bool flag = true;
            for(int i =0; i<arr.Length;i++)
            {
                if(arr[i].name.ToLower()==name.ToLower())
                {
                    Console.WriteLine(arr[i].showInfo());
                    flag = true;
                    break;
                } 
                else
                {
                    flag = false;
                }
               
               
            }    
             if(flag==false)
                {
                    Console.WriteLine("Sorry we cant find that Employerr");
                }
        }
      
        
    }
}
