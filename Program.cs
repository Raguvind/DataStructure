namespace DataStructure
{
    using System;
    using Sort;

    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] {22,3,1,-20,45,67,-100,34};
            // int[] unsortedArray = new int[] {20,35,-15,7,55,1,-22};
            
            PrintArray("Bubble Sort", BubbleSort.Sort(unsortedArray));
            PrintArray("Bubble Sort Optimized", BubbleSort.SortOptimized(unsortedArray));
            PrintArray("Merge Sort", MergeSort.Sort(unsortedArray));

            // RunBubbleSort(unsortedArray);
            // RunSelectionSort(unsortedArray);
            // RunInsertionSort(unsortedArray);
            // RunShellSort(unsortedArray);
        }

        static void RunShellSort(int[] array)
        {
            var sortAlgorithm = new ShellSort();
            var result = sortAlgorithm.Sort(array);
            PrintArray("Shell Sort",  result);
        }

        static void RunInsertionSort(int[] array)
        {
            var sortAlgorithm = new InsertionSort();
            var result = sortAlgorithm.Sort(array);
            PrintArray("Insertion Sort",  result);
        }

        /// Summary: Represents the method that runs the selection sort for the array.
        static void RunSelectionSort(int[] array)
        {
            /// Sorting the array by selection sort
            var sortAlgorithm = new SelectionSort();
            var result = sortAlgorithm.Sort(array);
            PrintArray("Selection Sort",  result);
        }

        static void PrintArray(string sortName, int[] sortedArray)
        {
            Console.WriteLine("***************** " + sortName + " *****************" );

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ==> " );
            }
            Console.WriteLine();
        }
    }
}