namespace _09_16.TasksStudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private List<int> marks;
        private string email;
        private int groupNumber;

        public Student(string firstName, string lastName, int fn, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

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
                    throw new ArgumentNullException("First name should exist");
                }
                this.lastName = value;
            }
        }

        public int FN
        {
            get
            { return this.fn; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentOutOfRangeException("Student number should be between 100000 and 999999");
                }
                this.fn = value;
            }
        }

        public string Tel
        {
            get
            { return this.tel; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentNullException("Telephone number cannot be shorter than 3 numbers");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get
            { return this.email; }
            set
            {
                if (value.IndexOf("@") == -1 || value.IndexOf(".") == -1)
                {
                    throw new ArgumentNullException("This is not a valid e-mail");
                }
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            { return this.groupNumber; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Group number should be between 1 and 9");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get
            { return this.marks; }
            set
            {
                foreach (var mark in value)
                {
                    if (mark < 2 || mark > 6)
                    {
                        throw new ArgumentOutOfRangeException("Marks should be between 2 and 6!");
                    }
                }
                this.marks = value;
            }
        }

        public string ReturnMarks()
        {
            string marks = string.Empty;

            foreach (var item in this.Marks)
            {
                marks += item + ", ";
            }

            if (marks != string.Empty)
            {
                marks = marks.Substring(0, marks.Length - 2);
            }
            return marks;
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
