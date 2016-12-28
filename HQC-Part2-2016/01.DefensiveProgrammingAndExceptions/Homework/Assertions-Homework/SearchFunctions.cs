using System;
using System.Diagnostics;

namespace AssertionsHomework
{
    public class SearchFunctions
    {
        internal static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(value != null, "Searched value is null!");
            Debug.Assert(arr != null, "Array to search in is null!");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index is out of range!");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "End index is out of range!");
            Debug.Assert(startIndex < endIndex, "End index is smaller than the start index!");
            Debug.Assert(Utils.IsArraySorted(arr), "Array must be sorted for Binary Search!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(!Utils.DoesValueExists(arr, value), "The searched value exists but Binarry search is returning -1");
            
            // Searched value not found
            return -1;
        }
    }
}
