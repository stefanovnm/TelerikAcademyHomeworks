namespace _03.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Sex sex)
            :base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cwak cwak");
        }
    }
}
