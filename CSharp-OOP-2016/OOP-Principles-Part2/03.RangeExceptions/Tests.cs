namespace _03.RangeExceptions
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            int[] integers = new int[] { 1, 2, 10, 99 }; //change here

            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
                if (integer < 1 || integer > 100)
                {
                    throw new InvalidRangeException<int>("Number is ot of range!", 1, 100);
                }
            }
            Console.WriteLine("All integers are in range!\n");

            DateTime date = new DateTime(2012, 6, 27); //change here
            Console.WriteLine(date);
            if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Date is out of range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            Console.WriteLine("Date is correct!");
        }
    }
}
