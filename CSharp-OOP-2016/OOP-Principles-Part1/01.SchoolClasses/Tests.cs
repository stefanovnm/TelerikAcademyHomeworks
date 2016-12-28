namespace _01.SchoolClasses
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            //students
            Student mariaStudent = new Student("Maria", "Ivanova", 9);
            mariaStudent.Comment = "simple student test";
            Console.WriteLine("Students:");
            Console.WriteLine("{0} {2} is {1}.", mariaStudent, mariaStudent.Comment, mariaStudent.FirstName);

            //teachers
            Teacher vasilenaTeacher = new Teacher("Ivanka", "Vasileva", new Discipline[] {new Discipline("Matemathics"), new Discipline("Physics",3,4)});
            vasilenaTeacher.Comment = "simple teacher test";
            Console.WriteLine("\nTeachers:");
            Console.WriteLine("{0} {1} is {2}", vasilenaTeacher, vasilenaTeacher.LastName,vasilenaTeacher.Comment);

            //class
            Class firstClass = new Class("Advance mathematics", 
                new Teacher[] { vasilenaTeacher, new Teacher("Ivan", "Ivanov", new Discipline[] { new Discipline("Chemistry") })}, 
                mariaStudent);
            Console.WriteLine("\nClasses:");
            Console.WriteLine(firstClass);

            firstClass.AddStudent(new Student("Vanko", "Belqta", 11));
            firstClass.RemoveTeacher(vasilenaTeacher);

            Console.WriteLine("\n"+firstClass);

        }
    }
}
