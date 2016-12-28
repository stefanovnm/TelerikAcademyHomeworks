using System;

using  NUnit.Framework;
using SchoolSystem.Models;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class StudentClassTests
    {
        [Test]
        public void Student_Constructor_ShouldReturnObjectWithClassStudent()
        {
            Assert.IsInstanceOf<Student>(new Student("first", "last", Grade.Eighth));
        }

        [Test]
        public void Student_ShouldThrw_IfNameIsTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("a", "test", Grade.Eighth));
        }

        [Test]
        public void Student_ShouldThrow_IfNameIsTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("aaaabbbbaaaabbbbaaaabbbbaaaabbbbaaaabbbb", "test", Grade.Eighth));
        }

        [Test]
        public void StudentShouldThrow_IfNameContainsSymbolWhichIsNotLetter()
        {
            Assert.Throws<ArgumentException>(() => new Student("Test1", "Test", Grade.Eighth));
        }

        [Test]
        public void Student_ShowMarks_ShouldLeaveMessageIfThereIsNoMark()
        {
            var student = new Student("Gosho", "Pesho", Grade.Eighth);

            Assert.That(student.ListMarks() == "This student has no marks.");
        }
    }
}
