namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Tests
    {
        public static void Main()
        {
            var list = new List<int> { 2, 10, -2, 55, 44, -22, 100 };

            Console.WriteLine("Elements: ");

            foreach (var element in list)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sum: ".PadLeft(10) + list.Sum());
            Console.WriteLine("Product: ".PadLeft(10) + list.Product());
            Console.WriteLine("Min: ".PadLeft(10) + list.Min());
            Console.WriteLine("Max: ".PadLeft(10) + list.Max());
            Console.WriteLine("Average: ".PadLeft(10) + list.Average());

        }
    }
}
