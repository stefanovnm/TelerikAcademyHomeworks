//Define a new class Student which is derived from Human and has a new field – grade. 

namespace _02.StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }
        
        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (value<2 || value>6)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 2 and 6!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} with grade {2}", this.FirstName, this.LastName, this.grade);
        }
    }
}
