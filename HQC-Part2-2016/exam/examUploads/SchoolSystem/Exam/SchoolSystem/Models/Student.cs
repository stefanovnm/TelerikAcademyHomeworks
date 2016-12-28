using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Models
{
    public class Student : Person
    {
        private Grade grade;
        private IList<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
            this.marks = new List<Mark>();
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                this.grade = value;
            }
        }

        public IList<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }
        }

        public string ListMarks()
        {
            string result = string.Empty;
            if (this.marks.Count == 0)
            {
                result = "This student has no marks.";
            }
            else
            {
                var allMarks = this.marks.Select(mark => $"{mark.Subject} => {mark.Value}").ToList();
                result = "The student has these marks:\n" + string.Join("\n", allMarks) + "\n";
            }

            return result;
        }
    }
}
