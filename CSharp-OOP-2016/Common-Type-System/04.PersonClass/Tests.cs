namespace _04.PersonClass
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Person ivan = new Person("Ivan");
            Console.WriteLine(ivan);

            Person kolio = new Person("Kolio", 29);
            Console.WriteLine(kolio);
        }
    }
}
