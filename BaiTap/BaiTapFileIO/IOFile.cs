using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace BaiTapFileIO
{


    public class IOFile

    {
        public int[,] matrix{get;set;}
      /*  public int[,] matrixMul { get; set; }*/
        public int row { get; set; }
        public int col { get; set; }
        public int[,] ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
      /*          matrixMul = new int[row, col];*/
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i]);


                    }
                    rowIndex++;
                }
                return matrix;

            }
        }
      public void WriteFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write("Tổng giá trị trong ma trận: ");
                sw.WriteLine(Algorithm.TotalofMatrix(matrix));
                sw.Write("Số lượng số nguyên tố: ");
                sw.WriteLine(Algorithm.CountNumberPrime(matrix));
                sw.Write("Số lượng số lẻ:");
                sw.WriteLine(Algorithm.CountNumberOdd(matrix));
                sw.Write("Tổng giá trị đường biên: ");
                sw.WriteLine(Algorithm.totalOfSide(matrix));
                sw.WriteLine("Giá trị ma trận nhân 3: ");
                Algorithm.MulMatrix(matrix, 3);
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
