namespace DataStructure.Sort
{
    using System;
    
    /// Summary: Represents the class that does the bubble sort.
    ///          Bubbles the largest number to the left of the array and sort.
    /// Complexity: O(n2) [Big O of n-square]
    public class BubbleSort
    {
        /// Summary: Represents the method that does the default bubble sort.
        public int[] Sort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
                for (int j = 0; j < unsortedArray.Length; j++)
                    if(unsortedArray[i] < unsortedArray[j])
                        SortHelper.Swap(unsortedArray, i, j);

            return unsortedArray;
        }

        /// Summary: Represents the method that sorts the array using an optimized version of the bubble sort.
        public int[] SortOptimized(int[] unsortedArray)
        {
            /// In this optimized logic, we track the sorted items that moves to the right most side of the array.
            /// this performs better than the default bubble sort.
            for (int lastUnSortedIndex = unsortedArray.Length - 1; lastUnSortedIndex >= 0 ; lastUnSortedIndex--)
                for (int j = 0; j <= lastUnSortedIndex; j++)
                    if(unsortedArray[lastUnSortedIndex] < unsortedArray[j])
                        SortHelper.Swap(unsortedArray, lastUnSortedIndex, j);

            return unsortedArray;
        }
   }
}