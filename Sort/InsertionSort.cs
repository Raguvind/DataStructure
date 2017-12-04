namespace DataStructure.Sort
{
    using System;
    
    /// Summary: Represents the class that does the insertion sort.
    ///          In this algorithm we start from the left most item in the array assuming that it is in the sorted position
    ///          compare that with the next element and then check if that is less than the current element.
    ///          if the element is less then 
    /// Complexity: O(n2) [Big O of n-square]
    public class InsertionSort
    {
        /// Summary: Represents the method that sorts the array.
        public int[] Sort(int[] unsortedArray)
        {
            /// Looping through the entire array, the assumption is that the first element in 0 position is sorted
            /// so the comparison is started from the first index position
            for (int firstSortedIndex = 1; firstSortedIndex < unsortedArray.Length; firstSortedIndex++)
            {
                /// Assigning the item that needs to be compared in a temp variable called element.
                int currentElement = unsortedArray[firstSortedIndex];
                
                /// Looping through all the element that are less than the index of the first sorted position / current element index.
                /// Loop through starting from the first sort index going behind till we find a index where the current element is 
                /// greated than the item in the array. 
                /// If we reach that position that is where we need to insert our current element, till that we keep moving the item one position at a time.
                int i;
                for (i = firstSortedIndex; i > 0; i--)
                {
                    if(unsortedArray[i - 1] > currentElement)
                        unsortedArray[i] = unsortedArray[i-1];
                    else
                    {
                        /// Breaking the item swap as the current element is greater than the item that is being compared
                        /// and the current element needs to be inserted in this location.
                        break;
                    }
                }
                unsortedArray[i] = currentElement;
            }
            return unsortedArray;
        }
    }
}