namespace _18_19.GroupedByGroupNumber
{
    using System;
    using System.Linq;

    public class GroupedByGroupNumber
    {
        public static void Main()
        {
            Student[] students = new Student[] {
                new Student("Ivan","Ivanov",1),
                new Student("Iva","Ivanova",5),
                new Student("Georgi","Georigev",4),
                new Student("Stefan","Koichev",2),
                new Student("Kolio","Koleshev",6),
                new Student("Deso","Kelesha",7),
                new Student("Donka","Koleva",8),
                new Student("Vanko","Hristov",9),
                new Student("Anatoli","Popov",3),
                new Student("Jivko","Ivanov",9),
                new Student("Toshko","Popov",2),
                new Student("Maria","Stefanova",6),
                new Student("Nikola","Nikolov",8),
                new Student("Eva","Malcheva",6),
            };

            Console.WriteLine("All students:");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nTask 18");
            var groupByGroupNumber = from student in students
                                     orderby student.GroupNumber
                                     select student;
            foreach (var student in groupByGroupNumber)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nTask 19");
            var groupByGroupName = students.OrderBy(student => student.GroupName);

            foreach (var student in groupByGroupName)
            {
                Console.WriteLine(student);
            }

        }
    }
}
