using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchoolSystem;

namespace SchoolSystem.Models
{
    public class Teacher : Person
    {
        private Subject subject;

        public Teacher(string firstName, string lastName, Subject subject)
            : base(firstName, lastName)
        {
            this.Subject = subject;
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                this.subject = value;
            }
        }

        public void AddMark(Student student, float value)
        {
            var mark = new Mark(this.subject, value);
            student.Marks.Add(mark);
        }
    }
}
