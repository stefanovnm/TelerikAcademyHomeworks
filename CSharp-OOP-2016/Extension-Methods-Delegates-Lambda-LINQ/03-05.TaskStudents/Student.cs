namespace _03_05.TaskStudents
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name should exist");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name should exist");
                }

                this.lastName = value;
            }
        }

        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 150 years");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " - "+ this.age.ToString();
        }

    }
}
