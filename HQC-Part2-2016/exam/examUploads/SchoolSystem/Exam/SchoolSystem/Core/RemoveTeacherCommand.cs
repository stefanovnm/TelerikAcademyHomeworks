using System.Collections.Generic;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class remove teacher from list of teachers.
    /// </summary>
    internal class RemoveTeacherCommand : ICommand
    {
        /// <summary>
        /// Remove teacher from the list of teachers by id
        /// </summary>
        /// <param name="teacherIds">id to delete</param>
        /// <returns>Delete the teacher and print information about</returns>
        public string Execute(IList<string> teacherIds)
        {
            Engine.Teachers.Remove(int.Parse(teacherIds[0]));
            return $"Teacher with ID {int.Parse(teacherIds[0])} was sucessfully removed.";
        }
    }
}
