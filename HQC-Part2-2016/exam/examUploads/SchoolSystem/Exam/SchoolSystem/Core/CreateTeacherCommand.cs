using System.Collections.Generic;

using SchoolSystem.Models;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class create a teacher from parameteres
    /// </summary>
    internal class CreateTeacherCommand : ICommand
    {
        private static int id = 0;

        /// <summary>
        /// Create a teacher and print information about him
        /// </summary>
        /// <param name="parameters">List with 3 parameters: first name, second name and subject</param>
        /// <returns>Adds teacher to the list of teachers and print information about</returns>
        public string Execute(IList<string> parameters)
        {
            Engine.Teachers.Add(id, new Teacher(parameters[0], parameters[1], (Subject)int.Parse(parameters[2])));
            return $"A new teacher with name {parameters[0]} {parameters[1]}, subject {(Subject)int.Parse(parameters[2])} and ID {id++} was created.";
        }
    }
}
