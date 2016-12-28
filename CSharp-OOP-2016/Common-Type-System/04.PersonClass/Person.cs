namespace _04.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int? age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            string format = "Name: {0}; Age: {1}";
            string result;
            if (this.Age == null)
            {
                result = string.Format(format, this.name, "Not specified");
            }
            else
            {
                result = string.Format(format, this.name, this.age);
            }

            return result;
        }

    }
}
