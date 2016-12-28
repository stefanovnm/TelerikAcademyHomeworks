using System.Collections.Generic;

namespace SchoolSystem.Core
{
    /// <summary>
    /// This class is caring about teacher adding mark to student
    /// </summary>
    internal class TeacherAddMarkCommand : ICommand
    {
        /// <summary>
        /// Teacher add mark to student
        /// </summary>
        /// <param name="parameters">Parameters are : teacher's Id, student's Id and mark for the student</param>
        /// <returns>Add mark and print information about</returns>
        public string Execute(IList<string> parameters)
        {
            var teacherId = int.Parse(parameters[0]);
            var studentId = int.Parse(parameters[1]);

            var student = Engine.Students[studentId];
            var teacher = Engine.Teachers[teacherId];
            teacher.AddMark(student, float.Parse(parameters[2]));

            return $"Teacher {teacher.FirstName} {teacher.LastName} added mark {float.Parse(parameters[2])} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";
        }
    }
}
