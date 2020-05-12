using System;

namespace KiemTra
{
    class Cau1
    {
        static void Main(string[] args)
        {
            int[,] matrix = { };
            Menu(matrix);
        }
        static void Menu(int[,] matrix)
        {
            int choice = -1;
            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("MATRIX SYSTEM");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Create new matrix");
                Console.WriteLine("2. Calculate each row in matrix");
                Console.WriteLine("3. Find the biggest row in matrix");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Choice(choice, matrix);

            }
        }
        public static void Choice(int choice, int[,] matrix)
        {
           
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("input row:");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("input coloums:");
                    int col = Convert.ToInt32(Console.ReadLine());
                    matrix = CreateMatrix(row, col);
                    break;
                case 2:
                    Console.Clear();
                    SumOfRowMaTrix(matrix);

                    break;
                case 3:
                    Console.Clear();
                    ShowMaxRow(matrix);
                    break;
                case 4:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            Menu(matrix);
        }
        public static int[,] CreateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random r = new Random();
            for(int i =0; i<row; i++)
                for(int j =0; j<col;j++)
                    matrix[i, j] = r.Next(10, 50);    
            return matrix;
        }
        public static void SumOfRowMaTrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
              
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];

                }
                Console.WriteLine(sum);
                sum = 0;
            }

        }
        public static void ShowMaxRow(int[,] matrix)
        {
            int sum=0;
            int maxrow = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
              
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];

                }   
                if (sum>maxrow)

                {
                    maxrow = sum;
                }
                sum = 0;
            }
            Console.WriteLine(maxrow);
        }
        //check matrix
      /*  public static void ShowMaTrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
            }
            
        }*/

    }
}
