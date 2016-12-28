using System.Collections.Generic;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class shows all marks for current student
    /// </summary>
    internal class StudentListMarksCommand : ICommand
    {
        /// <summary>
        /// Shows all marks for current student by id
        /// </summary>
        /// <param name="studentIds">id to show</param>
        /// <returns>All marks for the student</returns>
        public string Execute(IList<string> studentIds)
        {
            return Engine.Students[int.Parse(studentIds[0])].ListMarks();
        }
    }
}
