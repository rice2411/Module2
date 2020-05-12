using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Insertionsort
    {
        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {

                int value = arr[i];
                int k;
                for (k = i - 1; k >= 0 && arr[k] > value; k--)
                {
                    arr[k + 1] = arr[k];
                }

                arr[k + 1] = value;
            }
        
        }
    }
}
