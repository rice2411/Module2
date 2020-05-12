using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
   static class HelpFunction
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp ;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Show(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }    
        }
    }
}
