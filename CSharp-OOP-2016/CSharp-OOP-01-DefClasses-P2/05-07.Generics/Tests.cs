namespace _05_07.Generics
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            GenericList<int> firstList = new GenericList<int>();
            Console.WriteLine(firstList);

            //testing Add
            firstList.Add(31);
            Console.WriteLine(firstList);

            //testing AddAtPosition
            firstList.AddAtPosition(52,0);
            Console.WriteLine(firstList);

            //testing FindFirst
            int findThis = 31;
            int firstOccur = firstList.FindFirst(findThis);
            Console.WriteLine("Element {0} is with {1} index",findThis, firstOccur);

            //testing Remove
            firstList.Remove(1);
            Console.WriteLine(firstList);

            //testing Clear
            firstList.Clear();
            Console.WriteLine(firstList);

            GenericList<int> secondList = new GenericList<int>();

            for (int i = 0; i < 2; i++)
            {
                secondList.Add(0);
                secondList.Add(10);
                secondList.Add(15);
                secondList.Add(5);
                secondList.Add(3);
                secondList.Add(-1);
                secondList.Add(100);
            }
            
            

            Console.WriteLine(secondList);

            Console.WriteLine("Min is {0}", secondList.Min());
            Console.WriteLine("Max is {0}", secondList.Max());

        }
    }
}
