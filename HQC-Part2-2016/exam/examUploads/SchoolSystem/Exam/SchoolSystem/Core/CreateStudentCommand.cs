using System.Collections.Generic;

using SchoolSystem.Models;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class create a student from parameteres
    /// </summary>
    internal class CreateStudentCommand : ICommand
    {
        private static int id = 0;

        /// <summary>
        /// Create a student and print information about him
        /// </summary>
        /// <param name="parameters">List with 3 parameters: first name, second name and grade</param>
        /// <returns>Adds student to the list of students and print information about</returns>
        public string Execute(IList<string> parameters)
        {
            Engine.Students.Add(id, new Student(parameters[0], parameters[1], (Grade)int.Parse(parameters[2])));
            return $"A new student with name {parameters[0]} {parameters[1]}, grade {(Grade)int.Parse(parameters[2])} and ID {id++} was created.";
        }
    }
}
