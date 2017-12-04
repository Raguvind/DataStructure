namespace DataStructure.Sort
{
    using System;

    public static class SortHelper
    {
        /// Summary: Represents the method that swaps the two elements in an array
        public static void Swap(int[] array, int i, int j)
        {
            if(i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}