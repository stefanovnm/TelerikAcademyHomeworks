using System;

namespace AssertionsHomework
{
    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortingFunctions.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            SortingFunctions.SelectionSort(new int[0]);

            // Test sorting single element array
            SortingFunctions.SelectionSort(new int[1]); 

            Console.WriteLine(SearchFunctions.BinarySearch(arr, -1000));
            Console.WriteLine(SearchFunctions.BinarySearch(arr, 0));
            Console.WriteLine(SearchFunctions.BinarySearch(arr, 17));
            Console.WriteLine(SearchFunctions.BinarySearch(arr, 10));
            Console.WriteLine(SearchFunctions.BinarySearch(arr, 1000));
        }
    }
}
