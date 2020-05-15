/*using System;
using System.IO;
using FileIO;
using System.Text;
namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string pathinput = @"D:\CodeGym\Module2\Baitap\BaiTap\FileIO\File\input.txt";
            string pathoutput = @"D:\CodeGym\Module2\Baitap\BaiTap\FileIO\File\output.txt";
            int[,] matrix;
            int row, col;
            using(StreamReader sr = File.OpenText(pathinput))
            {
                string line = "";
                line = sr.ReadLine();
                string[]rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
                int rowIndex = 0;
                while((line = sr.ReadLine())!= null)
                {
                    string[] rows = line.Split(" ");
                    for(int i =0; i< rows.Length;i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i])*2;
                    }
                    rowIndex++;
                }
            }
            using(StreamWriter sw  = File.AppendText(pathoutput))
            {
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
            *//*  File.Create(path);
             if (File.Exists(path))
                 File.Delete(path);
             using (StreamWriter sw = File.CreateText(path))
             {
                 sw.WriteLine("LEESIN THẦY TU MÙ");
                 sw.WriteLine("JAVAN ĐỆ TỨ");
             };
             using (StreamReader sr = File.OpenText(path))
             {
                 string valueofline = "";
                 while ((valueofline = sr.ReadLine()) != null)
                     Console.WriteLine(valueofline);
             };*//*
        }
    }
}
*/