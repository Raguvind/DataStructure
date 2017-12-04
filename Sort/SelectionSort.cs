namespace DataStructure.Sort
{
    using System;
    
    /// Summary: Represents the class that does the selection sort.
    ///          Selects the largest number and moves it to the left of the array and sort.
    /// Complexity: O(n2) [Big O of n-square]
    public class SelectionSort
    {
        /// Summary: Represents the method that sorts the array using an optimized version of the bubble sort.
        public int[] Sort(int[] unsortedArray)
        {
            for (int lastSortedIndex = unsortedArray.Length - 1; lastSortedIndex >= 0; lastSortedIndex--)
            {
                int largestIndex = 0;
                /// Looping through the array to get the index of the largest element in the array.
                /// assign the largest index to the largest index variable.
                for (int i = 0; i <= lastSortedIndex; i++)
                {
                    if(unsortedArray[largestIndex] < unsortedArray[i])
                        largestIndex = i;
                }

                /// If largest index is not equal to last sorted indext then swap the element.
                SortHelper.Swap(unsortedArray, largestIndex, lastSortedIndex);
            }
            return unsortedArray;
        }
    }
}