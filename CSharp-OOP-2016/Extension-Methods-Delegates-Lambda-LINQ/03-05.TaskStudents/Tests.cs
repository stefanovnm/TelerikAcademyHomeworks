namespace _03_05.TaskStudents
{
    using System;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            Student[] students = new Student[] {new Student("Ivan", "Vankata", 20),
            new Student("Ivan","Ivanov", 25), new Student("Georgi","Georgiev", 23),
            new Student("Momchil","Georgiev", 22), new Student("Ivan","Andreev",24)};

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


            Console.WriteLine("\nTask 3:\nStudents whose first name is before its last name alphabetically:");

            var firstBeforeLast = from student in students
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nTask 4:\nFirst name and last name of all students with age between 18 and 24:");

            var studentByAgeRange = from student in students
                                  where student.Age > 18 && student.Age < 24
                                  select student;

            foreach (var student in studentByAgeRange)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nTask 5:\nSort the students by first name and last name in descending order:");

            var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
