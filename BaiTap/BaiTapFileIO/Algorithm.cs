using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapFileIO
{
   static class  Algorithm
    {
        public static int[,] MulMatrix(int[,] matrix, int num)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = matrix[i, j] * num; 
            return matrix;
        }
        public static int TotalofMatrix(int[,] matrix)
        {
            int total = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    total+=matrix[i,j];
            return total;
        }
       public static int CountNumberOdd(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j]/2!=0)
                        count++;
            return count;
        }
       public  static int CountNumberPrime(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (isPrime(matrix[i, j]))
                        count++;
            return count;
        }
        public static bool isPrime(int num)
        {
         
         
            for (int i = 1; i < num - 1; i++)
            {
                if (num < 2)
                {
                    return false;
                }
                else if(num==2)
                {
                    return true;
                }
                 else if (num % i == 0)
                {
                    return false;
                }
                    
            }
            return true;
        }
        public static int totalOfSide(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[0, i];
                sum += arr[arr.GetLength(0) - 1, i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, 0];
                sum += arr[i, arr.GetLength(1) - 1];
            }
            return sum;
        }
    }
}
