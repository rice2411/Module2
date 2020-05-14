using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapFileIO
{
   static class  Algorithm
    {
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

                sum += arr[arr.GetLength(0) - 1, i];
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                sum += arr[i, arr.GetLength(1) - 1];
            }
            return sum;
        }
    }
}
