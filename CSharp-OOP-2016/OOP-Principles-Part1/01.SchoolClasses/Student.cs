namespace _01.SchoolClasses
{
    using System;

    public class Student : Person
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            :base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("Class cannot be positive");
                }

                if (value > 13)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be larger than 13");
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0} {1} is with class number {2}.", this.FirstName, this.LastName, this.ClassNumber);
        }
    }
}
