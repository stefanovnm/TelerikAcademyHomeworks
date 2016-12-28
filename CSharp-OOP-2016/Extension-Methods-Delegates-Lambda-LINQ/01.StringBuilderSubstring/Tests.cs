namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    public class Tests
    {
        public static void Main()
        {
            string test = "just one test for the purpose";
            Console.WriteLine("String:\n" + test.Substring(9, 20));

            StringBuilder sb = new StringBuilder();
            sb.Append("just one test for the purpose");
            Console.WriteLine("StringBuilder:\n"+sb.Substring(9,20));
        }
    }
}
