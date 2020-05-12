using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 9, 2, 6, 8, 7, 4, 3, 5 };
            Bubblesort bbs = new Bubblesort();
            DateTime start = DateTime.Now;
            bbs.BubbleSort(arr);
            DateTime end = DateTime.Now;
            Console.WriteLine($"BubbleSort time working: {end - start} ms");
            HelpFunction.Show(arr);
            Console.WriteLine();
            Console.WriteLine("----------------");

            int[] arr1 = { 1, 9, 2, 6, 8, 7, 4, 3, 5 };
            Selectionsort sls = new Selectionsort();
            DateTime start1 = DateTime.Now;
            sls.SelectionSort(arr1);
            DateTime end1 = DateTime.Now;
            Console.WriteLine($"SelectionSort time working:{end1 - start1} ms ");
            HelpFunction.Show(arr1);
            Console.WriteLine();
            Console.WriteLine("----------------");

            int[] arr2 = { 1, 9, 2, 6, 8, 7, 4, 3, 5 };
            Insertionsort iss = new Insertionsort();
            DateTime start2 = DateTime.Now;
            iss.InsertionSort(arr2);
            DateTime end2 = DateTime.Now;
            Console.WriteLine($"InsertionSort time working:{end2 - start2} ms ");
            HelpFunction.Show(arr2);
            Console.WriteLine();
            Console.WriteLine("----------------");

        }
       
     

    }
}
