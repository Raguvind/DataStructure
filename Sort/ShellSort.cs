namespace DataStructure.Sort
{
    using System;
    
    /// Summary: Represents the class that does the shell sort.
    ///          This algorithm does the same as the insertion sort except that instead of comparing the previous itme
    ///          a gap element is used and based on which the insert sort is applied.
    /// Complexity: O(n2) [Big O of n-square], but generally this performs better than insertion sort because of the gap element.
    ///             by the time the gap reaches 1 the array is already sorted.
    public class ShellSort
    {
        /// Summary: Represents the method that sorts the array.
        public int[] Sort(int[] unsortedArray)
        {
            /// In this sample we are by default taking the gap as total lenght of the array divided by 2.
            /// This is the first gap value and from here we keep reducing the gap value to reach 1.
            int gap = unsortedArray.Length / 2;

            for (; gap > 0; gap = gap / 2)
            {
                /// Looping through the array based on the gap and checking if the array item is less than the gap element.
                /// If yes then swap the element with the help of the inner loop.
                for (int firstSortedIndex = gap; firstSortedIndex < unsortedArray.Length; firstSortedIndex = firstSortedIndex + gap)
                {
                    int currentElement = unsortedArray[firstSortedIndex];
                    int i;
                    for (i = firstSortedIndex; i > 0 && currentElement < unsortedArray[i-gap] ; i = i-gap)
                    {
                        unsortedArray[i] = unsortedArray[i-gap];
                    }
                    unsortedArray[i] = currentElement;
                }
            }
            return unsortedArray;
        }
    }
}