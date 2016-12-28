namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age shouldn't be negative!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public Sex Sex { get; set; }

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            double averageAge = animals.Average(animal => animal.Age);
            return averageAge;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} is {1} years old. It's {2}", this.Name, this.Age, this.Sex);
        }
    }
}
