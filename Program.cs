namespace DataStructure
{
    using System;
    using Sort;

    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] {22,3,1,-20,45,67,-100,34};
            
            RunBubbleSort(unsortedArray);
            RunSelectionSort(unsortedArray);
        }

        /// Summary: Represents the method that runs the selection sort for the array.
        static void RunSelectionSort(int[] array)
        {
            /// Sorting the array by bubble sort
            var sortAlgorithm = new SelectionSort();
            var result = sortAlgorithm.Sort(array);
            PrintArray("Selection Sort",  result);
        }

        /// Summary: Represents the method that runs the bubble sort for the array.
        static void RunBubbleSort(int[] array)
        {
            /// Sorting the array by bubble sort
            var bubbleSortAlgorithm = new BubbleSort();
            var bubbleSortResult = bubbleSortAlgorithm.Sort(array);
            PrintArray("Bubble Sort",  bubbleSortResult);
            bubbleSortResult = bubbleSortAlgorithm.SortOptimized(array);
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
