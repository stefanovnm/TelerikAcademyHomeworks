namespace _09_16.TasksStudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestStudentGroup
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {new Student ("Petyr", "Petrov", 134606,"+359212","ab@abv.bg",new List<int> {3,3,3},2),
                new Student ("Georgi","Popov",231106,"+359322","bc@gmail.com",new List<int> {6,6,4},1), 
                new Student ("Ivan","Ivanov",134605,"+359233","cd@abv.bg", new List<int> {6,6,5,3},2),
                new Student ("Andrei","Andreev",121007,"+359544","de@yahoo.com",new List<int> {2,2},1),
                new Student ("Ivan","Stefanov",133006,"+359432","ef@abv.bg", new List<int> {2,6},2)};

            Console.WriteLine("All students:");
            foreach (var student in students)
            {
                Console.WriteLine(student + ": FN-" + student.FN + ", Te:" + student.Tel + ", Mail: " + student.Email + ", Group: " + student.GroupNumber + ", Marks: " + student.ReturnMarks());
            }

            //Task 9 (LINQ)
            Console.WriteLine("\nTask 9:\nLinq:");
            var listOfStudentsSecondGroup = from student in students
                                            where student.GroupNumber == 2
                                            orderby student.FirstName
                                            select student;

            foreach (var student in listOfStudentsSecondGroup)
            {
                Console.WriteLine(student);
            }

            //Task 10 (Extension method)
            Console.WriteLine("\nTask 10:\nExtension method:");
            var secondListOfStudentsSecondGroup = students
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);

            foreach (var student in secondListOfStudentsSecondGroup)
            {
                Console.WriteLine(student);
            }

            //Task 11 (LINQ)
            Console.WriteLine("\nTask 11:\nMail in abv.bg:");
            var studentWithEmailsInAbv = from student in students
                                         where student.Email.IndexOf("@abv.bg") != -1
                                         select student;

            foreach (var student in studentWithEmailsInAbv)
            {
                Console.WriteLine(student+ " : " + student.Email);
            }

            //Task 12 (LINQ)
            Console.WriteLine("\nTask 12:\nPhone number from Sofia:");
            var studentsWithNumberFromSofia = from student in students
                                              where student.Tel[4] == '2' //fifth number +359 2 ...
                                              select student;
            
            foreach (var student in studentsWithNumberFromSofia)
            {
                Console.WriteLine(student+" : " + student.Tel);
            }

            //Task 13 (LINQ)
            Console.WriteLine("\nTask 13:\nAt least one mark excelent:");
            var studentsWithExcelent = from student in students
                                       where student.Marks.Contains(6)
                                       select student;
            
            foreach (var student in studentsWithExcelent)
            {
                Console.WriteLine(student + " : " + student.ReturnMarks());
            }

            //Task 14 (Extension method)
            Console.WriteLine("\nTask14:\nStudents with 2 marks:");
            var studentsWith2Marks = students.Where(student => student.Marks.Count == 2)
                .Where(student => student.ReturnMarks() == "2, 2"); //TODO: to improve

            foreach (var student in studentsWith2Marks)
            {
                Console.WriteLine(student+ " : " + student.ReturnMarks());
            }

            //Task 15
            Console.WriteLine("\nTask 15:\nAll marks from students from 2006:");
            var studentsFrom2006 = from student in students
                                   where student.FN % 100 == 06
                                   select student;

            string marks = string.Empty;
            string fromStudents = string.Empty;
            foreach (var student in studentsFrom2006)
            {
                marks += student.ReturnMarks() + ", ";
                fromStudents += student + ": " + student.FN + ", ";
            }
            if (marks != string.Empty)
            {
                marks = marks.Substring(0, marks.Length - 2);
                fromStudents = fromStudents.Substring(0, fromStudents.Length - 2);
            }
            Console.WriteLine(marks + ": " + fromStudents);

            //Task 16* missing


        }
    }
}
