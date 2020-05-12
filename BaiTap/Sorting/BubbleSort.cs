using System;

namespace Sorting
{
    class Bubblesort
    {
      
       public  void BubbleSort(int[] arr)
        {
            bool needToSort = true;
            for(int k =1;k<arr.Length && needToSort; k++)
            {
                needToSort = false;
                for (int i = 0; i < arr.Length-k; i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        HelpFunction.Swap<int>(ref arr[i], ref arr[i + 1]);
                        needToSort = true;
                    }
                   
                }
           
            }    
        }
     

    }
}
