using System;
using System.IO;
namespace BaiTapFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\InputData.txt";
            string pathOutput= @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\OutputData.txt";
            int[,] matrix,matrix2;
            int total = 0;
            int primeNumber = 0;
            int oddNumber = 0;
       
            int row, col;   
            using(StreamReader sr = File.OpenText(pathInput))
            {
                string line = "";
                line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
                matrix2 = new int[row, col];
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i])*3;
                        matrix2[rowIndex, i] = int.Parse(rows[i]);
                        total += int.Parse(rows[i]);
                        if (isPrime(int.Parse(rows[i])))
                            primeNumber++;
                        if(int.Parse(rows[i])/2!=0)
                            oddNumber++;

                    }
                    rowIndex++;
                }
            }
            
            using (StreamWriter sw = File.CreateText(pathOutput))
            {
                sw.Write("Tổng giá trị trong ma trận: ");
                sw.WriteLine(total);
                sw.Write("Số lượng số nguyên tố: ");
                sw.WriteLine(primeNumber);
                sw.Write("Số lượng số lẻ:");
                sw.WriteLine(oddNumber);
                sw.Write("Tổng giá trị đường biên: ");
                sw.WriteLine(totalOfSide(matrix2));
                sw.WriteLine("Giá trị ma trận nhân 3: ");
                sw.WriteLine($"{row} {col}");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix[i, j]} ");
                    }
                    sw.WriteLine();

                }
            }
        }
        public static bool isPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        public static int totalOfSide(int[,] arr)
        {
            int sum = 0;
      
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[0, i];

            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, 0];

            }

            for (int i = 0; i < arr.GetLength(1); i++)
            {

                sum += arr[arr.GetLength(0)-1, i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                sum += arr[i, arr.GetLength(1)-1];
            }
            return sum;
        }
    }
}
