using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
   public class Selectionsort
    {
  
        public void SelectionSort(int[]arr)
        {
            int minValue = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                minValue = i;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[j]<arr[minValue])
                    {
                        minValue = j;
;                   }    
                }
                if (minValue != i)
                    HelpFunction.Swap<int>(ref arr[i], ref arr[minValue]);
            }    
        }
      
    }
}
