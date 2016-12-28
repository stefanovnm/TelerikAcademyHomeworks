namespace _07.Timer
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Timer timer = new Timer(1);

            timer.TEvent += FirstTest;
            timer.TEvent += SecontTest;
            timer.TEvent += ThirdTest;
            timer.TEvent -= SecontTest;

            Console.WriteLine("Press any key to stop:");

            timer.DoIt();
        }

        public static void FirstTest()
        {
            Console.WriteLine("First");
        }

        public static void SecontTest()
        {
            Console.WriteLine("Second");
        }

        public static void ThirdTest()
        {
            Console.WriteLine("Third");
        }
    }
}
