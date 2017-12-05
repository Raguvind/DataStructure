namespace DataStructure.Sort
{
    using System;

    /// <summary>
    /// Description: Represents the class that does the merge sort.
    ///              In this algorithm we sort the array by divide and conquer, we start by grouping the array in to smaller
    ///              arrays till we have a the entire array broken down into smaller one element array and then start merging these
    ///              smaller arrays by sorting them individually. So when the merge of all these smaller arrays are complete the entire
    ///              array is sorted.
    /// Complexity:  O(n2) [Big O of n-square]
    /// </summary>
    public static class MergeSort
    {

        /// <summary>
        /// Sorts the specified unsorted array using the merge sort algorithm.
        /// </summary>
        /// <param name="unsortedArray">The unsorted array.</param>
        /// <returns>Sorted array</returns>
        public static int[] Sort(int[] unsortedArray)
        {
            PartitionAndSort(unsortedArray, 0, unsortedArray.Length);
            return unsortedArray;
        }

        /// <summary>
        /// Partitions the specified array based into smaller array chunks till we have one element arrays.
        /// This is a recursive method that partitions the array till we reach the one element array.
        /// </summary>
        /// <param name="array">The array that needs to be partioned.</param>
        /// <param name="start">The start index of the array.</param>
        /// <param name="end">The end index of the array.</param>
        private static void PartitionAndSort(int[] array, int start, int end)
        {
            //// Threshold condition for the recursive method, this checks if the partition is reached a one element array.
            //// if the difference between the start and end is less than 2 that means the partition had only one element.
            if (end - start < 2)
                return;

            //// Computing the mid point, this is used to partition the array. In case if the array length is odd, the right side alway gets
            //// the bigger chunk of data, this can be otherwise as well.
            var mid = (start + end) / 2;

            //// Further recursively partitioning the array both on the right side as well as the left side till we have one element arrays, then we start merging and sorting.
            PartitionAndSort(array, start, mid); //// Left side array partition.
            PartitionAndSort(array, mid, end); //// Right side array partition.

            SortAndMerge(array, start, mid, end);
        }

        /// <summary>
        /// Merges the array and sort it, at this point the partition is complete and the merge and start is begining.
        /// The array that is being passed in has two partition, the elements between the start index and the mid - 1 is considered as the left partition
        /// the elements from the mid to the end is considered as the right partition.
        /// </summary>
        /// <param name="array">The array that needs to be sorted and merged backed.</param>
        /// <param name="start">The start index of the array.</param>
        /// <param name="mid">The mid index of the array.</param>
        /// <param name="end">The end index of the array that needs to be sorted and merged.</param>
        private static void SortAndMerge(int[] array, int start, int mid, int end)
        {
            //// Optimization #1: This is based on the assumption that the left partition and the right partition are sorted separetly.
            ////                  If the last element of the left partition is less than the first element of the right partition then both the partitions are 
            ////                  considered to the already sorted, so we return to the calling method.
            if (array[mid - 1] <= array[mid])
                return;

            //// Below is the actual sort that we do, by sorting the data an pushing the data into a temp array            
            //// The size of the array should be intialized in such a way that the array can accomidate all the elements between the start and end.
            var leftPartitionIndex = start;
            var rightPartitionIndex = mid;

            var tempArray = new int[end - start];
            var tempIndex = 0;

            //// The Sort logic basically compares the items in the left partition and the right partition of the array. 
            //// If the element in the left partition is greater than the right partition then take the item from the left partition and insert it into the temp
            //// array, else take the item from the right partition and insert it into the temp array.
            //// Also increment the partitionIndex which ever that is getting inserted into the temp array.
            while (leftPartitionIndex < mid && rightPartitionIndex < end)
            {
                tempArray[tempIndex++] = (array[leftPartitionIndex] >= array[rightPartitionIndex]) ? array[rightPartitionIndex++] : array[leftPartitionIndex++];
            }


            //// The tricky part of re-aligning the missed elements to the correct index.
            //// The logic that populates the elements into the temp array might leave out elements these elements can be either in the left partition or in the right partition.

            //// If it is in the left partition, then try to re-align the from the last position of the left partition index, the target start index is the start in the sort + total number of elements
            //// populated in the temp array, this re-aligns the missing elements starting from the left partition and moves it to the index right of the the total elements populated in the temp array.
            Array.Copy(array, leftPartitionIndex, array, start + tempIndex, mid - leftPartitionIndex);

            //// NOTE: Right index re-align is not needed. If the missed elements are in the right partition then the re-align of the items start 
            //// with the right index and moves the elements to the right of the array.
            //// This is not needed as the right index item are mostly in the same location.

            //// Copying the temp array into the actual array so that the items in the array is sorted.
            Array.Copy(tempArray, 0, array, start, tempIndex);
        }
    }
}