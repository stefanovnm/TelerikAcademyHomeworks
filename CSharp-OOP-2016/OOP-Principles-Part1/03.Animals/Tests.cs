namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Pesho", 2, Sex.male),
                new Cat("Rijko", 6, Sex.male),
                new Cat("Bella", 3, Sex.female),
                new Cat("Maca", 1, Sex.female),
                new Cat("Mara", 8, Sex.female),
            };

            Console.WriteLine("Cats:");

            foreach (var cat in cats)
            {
                Console.WriteLine(cat);
            }

            Console.WriteLine("\nAverage age of all cats is: {0}\n", Animal.CalculateAverageAge(cats));
            Console.WriteLine("Dogs:");

            Dog[] dogs = new Dog[]
            {
                new Dog("Roby", 4, Sex.male),
                new Dog("Charlie", 5, Sex.male),
                new Dog("Molly", 3, Sex.female),
                new Dog("Abby", 1, Sex.female),
                new Dog("Sara", 10, Sex.female),
            };

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine("\nAverage age of all dogs is: {0}\n", Animal.CalculateAverageAge(dogs));

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Bella", 3),
                new Kitten("Maca", 1),
                new Kitten("Mara", 8),
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Pesho", 2),
                new Tomcat("Rijko", 6),
            };

            var allAnimals = new List<Animal>();

            allAnimals.AddRange(tomcats);
            allAnimals.AddRange(kittens);
            allAnimals.AddRange(dogs);

            Console.WriteLine("Average age of all animals is: "+ Animal.CalculateAverageAge(allAnimals));

            var dogsFromAll = from animal in allAnimals
                              where animal.GetType() == typeof(Dog)
                              select animal;

            Console.WriteLine("\nAverage age of all dogs from a list of all animals is :"+Animal.CalculateAverageAge(dogsFromAll));
        }
    }
}
