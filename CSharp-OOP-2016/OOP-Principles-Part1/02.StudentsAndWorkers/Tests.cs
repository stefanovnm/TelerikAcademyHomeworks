//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            //http://listofrandomnames.com/ random names generator
            var students = new List<Student>()
            {
                new Student("Katharine", "Henegar", 4.5),
                new Student("Denae", "Pollan", 4.8),
                new Student("Shavon", "Luckow", 5.5),
                new Student("Carylon", "Sechrest", 6.0),
                new Student("Ezekiel", "Brinkmann", 5.45),
                new Student("Tristan", "Hatton", 5.66),
                new Student("Bette", "Presti", 3),
                new Student("Candi", "Sklar", 3.88),
                new Student("Craig", "Erdman", 4.5),
                new Student("Dario", "Blade", 4.89)
            };

            var sortedStudents = from student in students
                                 orderby student.Grade, student.FirstName
                                 select student;

            Console.WriteLine("Students order by grade:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            //workers

            var workers = new List<Worker>()
            {
                new Worker("Arnulfo", "Barlett", 350, 8),
                new Worker("Heath", "Kroner", 400, 8),
                new Worker("Barbar", "Luckow", 360, 8),
                new Worker("Marcie", "Yokota", 365, 8),
                new Worker("Petra", "Tannehill", 550, 8),
                new Worker("Arden", "Nathanson", 100, 8),
                new Worker("Lisa", "Blood", 200, 8),
                new Worker("Hilary", "Phegley", 210, 8),
                new Worker("Mohammed", "Bhatti", 206, 4),
                new Worker("Coralee", "Crownover", 310, 6)
            };

            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ThenBy(worker => worker.FirstName);

            Console.WriteLine("\nWorers sorted by money per hour:");
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            //merged human
            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            var sortedMerged = merged.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            Console.WriteLine("\nSorted merged students and workers sorted by name:");

            foreach (var human in sortedMerged)
            {
                Console.WriteLine(human);
            }
        }
    }
}
