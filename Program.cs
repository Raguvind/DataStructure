namespace DataStructure
{
    using System;
    using Sort;

    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] {22,3,1,-20,45,67,-100,34};
            
            /// Sorting the array by bubble sort
            var bubbleSortAlgorithm = new BubbleSort();
            var bubbleSortResult = bubbleSortAlgorithm.Sort(unsortedArray);
            PrintArray("Bubble Sort",  bubbleSortResult);
            bubbleSortResult = bubbleSortAlgorithm.SortOptimized(unsortedArray);
            PrintArray("Bubble Sort Optimized",  bubbleSortResult);
            
        }

        static void PrintArray(string sortName, int[] sortedArray)
        {
            Console.WriteLine("*****************" + sortName + "*****************" );

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ==> " );
            }
            Console.WriteLine();
        }
    }
}
