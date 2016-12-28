using System.Collections.Generic;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class remove student from list of students.
    /// </summary>
    internal class RemoveStudentCommand : ICommand
    {
        /// <summary>
        /// Remove student from the list of students by id
        /// </summary>
        /// <param name="studentIds">id to delete</param>
        /// <returns>Delete the student and print information about</returns>
        public string Execute(IList<string> studentIds)
        {
            Engine.Students.Remove(int.Parse(studentIds[0]));
            return $"Student with ID {int.Parse(studentIds[0])} was sucessfully removed.";
        }
    }
}
