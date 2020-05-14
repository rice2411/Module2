using System;
using System.IO;
namespace BaiTapFileIO
{
    class Program
    {
        public const int ZERO  = 0;
        public const int NUMBER_OF_EVEN = 2;
        static void Main(string[] args)
        {
            string pathInput = @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\InputData.txt";
            string pathOutput= @"D:\CodeGym\Module2\Baitap\BaiTap\BaiTapFileIO\File\OutputData.txt";
            int[,] matrix,matrix2;
            int total = ZERO;
            int primeNumber = ZERO;
            int oddNumber = ZERO;
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
                        if (Algorithm.isPrime(int.Parse(rows[i])))
                            primeNumber++;
                        if(int.Parse(rows[i])/NUMBER_OF_EVEN!= ZERO)
                            oddNumber++;
                        
                    }
                    rowIndex++;
                }
            }
            
            using (StreamWriter sw = File.AppendText(pathOutput))
            {
                sw.Write("Tổng giá trị trong ma trận: ");
                sw.WriteLine(total);
                sw.Write("Số lượng số nguyên tố: ");
                sw.WriteLine(primeNumber);
                sw.Write("Số lượng số lẻ:");
                sw.WriteLine(oddNumber);
                sw.Write("Tổng giá trị đường biên: ");
                sw.WriteLine(Algorithm.totalOfSide(matrix2));
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
        
    }
}
