namespace _18_19.GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int groupNumber;
        private string groupName;

        Dictionary<int, string> groups = new Dictionary<int, string>{
            { 1, "Mathematics" }, { 2, "Physics"}, 
            { 3, "History"}, { 4, "Science"},
            { 5, "IT"}, { 6, "English"},
            { 7, "Bulgarian"}, { 8, "Boilogy"},
            { 9, "Other"} };

        public Student(string firstName, string lastName, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupNumber = groupNumber;
            this.groupName = groups[groupNumber];
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

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Group numbers should be between 1 and 9 inclusive");
                }
                this.groupNumber = value;
            }
        }

        public string GroupName
        {
            get { return groups[this.groupNumber]; }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + ": " + this.groupNumber + "." + this.groupName;
        }
    }
}
