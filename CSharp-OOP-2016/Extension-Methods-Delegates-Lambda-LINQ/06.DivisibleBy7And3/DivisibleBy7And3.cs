namespace _06.DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            int[] array = new int[] {343, 651, 210, 698, 909, 519, 78, 911, 629, 630};
            
            Console.WriteLine("List of elements:");
            
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

            var listLinq = from number in array
                           where number % 7 == 0 && number % 3 == 0
                           orderby number
                           select number;

            Console.WriteLine("\n\nUsing Linq(additional sorted):");

            foreach (var element in listLinq)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("\n\nUsing extension methods(additional sorted):");

            var listExtension = array.Where(number => number % 7 == 0 && number % 3 == 0).OrderBy(x => x);

            foreach (var element in listExtension)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

        }
    }
}
