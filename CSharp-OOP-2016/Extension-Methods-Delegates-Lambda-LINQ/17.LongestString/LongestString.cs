namespace _17.LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            string[] array = new string[] { "test", "just test", "another test", "this task is really easy", "one more test" };

            Console.WriteLine(ReturnLongest(array));


        }
        //http://stackoverflow.com/questions/7975935/is-there-a-linq-function-for-getting-the-longest-string-in-a-list-of-strings

        static string ReturnLongest(string[] array)
        {
            string longest = string.Empty;

            longest = array.OrderByDescending(s => s.Length).First();

            return longest;
        }
    }
}
