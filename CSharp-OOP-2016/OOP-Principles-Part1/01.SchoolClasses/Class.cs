namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        private string identifier;
        private List<Teacher> setOfTeachers;
        private List<Student> setOfStudents;

        public Class(string identifier, Teacher[] setOfTeachers, params Student[] setOfStudents) //only one params
        {
            this.Identifier = identifier;
            this.setOfTeachers = new List<Teacher>();
            this.setOfTeachers.AddRange(setOfTeachers);
            this.setOfStudents = new List<Student>();
            this.setOfStudents.AddRange(setOfStudents);
        }

        public string Identifier
        {
            get { return this.identifier; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier cannot be empty!");
                }
                this.identifier = value;
            }
        }

        public List<Teacher> SetOfTeachers
        {
            get { return new List<Teacher>(this.setOfTeachers); }
        }

        public List<Student> SetOfStudents
        {
            get { return new List<Student>(this.setOfStudents); }
        }

        public string Comment { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.setOfStudents.Add(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public override string ToString()
        {
            return string.Format("Class {0}\nTeachers:\n{1}\nStudents:\n{2}", this.identifier, string.Join("\n", this.SetOfTeachers), string.Join("\n", this.setOfStudents));
        }
    }
}
