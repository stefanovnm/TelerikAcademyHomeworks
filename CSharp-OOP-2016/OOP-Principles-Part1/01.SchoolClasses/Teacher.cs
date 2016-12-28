namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName, params Discipline[] disciplines )
            :base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();

            foreach (var descipline in disciplines)
            {
                this.disciplines.Add(descipline);
            }
        }

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(this.disciplines); }
        }

        public void AddDiscpline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return string.Format("Teacher {0} {1} can teach {2}.", this.FirstName, this.LastName, string.Join(", ", this.Disciplines));
        }
    }
}
