namespace _01_03.StudentClass
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Student nikola = new Student("Nikola", "Ivanov", "Nikolov", "13444",
                "Sofia", "0888888888", "test@abv.bg", 3,
                Specialty.CivilEngineering, Faculty.Civil, University.UACEG);
            Console.WriteLine(nikola);

            Student clone = nikola;
            Console.WriteLine(clone);
            Console.WriteLine(nikola == clone);

            var copy = nikola.Clone();
            
            Console.WriteLine(nikola == copy);
            Console.WriteLine(nikola != copy);
            Console.WriteLine(nikola.GetHashCode());
            //Console.WriteLine(nikola.Equals(copy));

            Student tester = new Student("Momchil", "Ivanov", "Nikolov", "13444",
                "Sofia", "0888888888", "test@abv.bg", 3,
                Specialty.CivilEngineering, Faculty.Civil, University.UACEG);

            Console.WriteLine(tester);
            Console.WriteLine("Compare 2 students: "+ nikola.CompareTo(tester)+"!");
        }
    }
}
