using System;
using Moq;
using SchoolSystem.Models;
using NUnit.Framework;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class TeacherClassTests
    {
        [Test]
        public void Teacher_Constructor_ShouldReturnObjectWithClassStudent()
        {
            Assert.IsInstanceOf<Teacher>(new Teacher("first", "last", Subject.Bulgarian));
        }

        [Test]
        public void Teacher_ShouldThrw_IfNameIsTooShort()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher("a", "test", Subject.Bulgarian));
        }

        [Test]
        public void Teacher_ShouldThrow_IfNameIsTooLong()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Teacher("aaaabbbbaaaabbbbaaaabbbbaaaabbbbaaaabbbb", "test", Subject.Bulgarian));
        }

        [Test]
        public void Teacher_ShouldThrow_IfNameContainsSymbolWhichIsNotLetter()
        {
            Assert.Throws<ArgumentException>(() => new Teacher("Test1", "Test", Subject.Bulgarian));
        }

        [Test]
        public void Teacher_AddMark_ShouldIncreaseStudentMakrsWithOne()
        {
            var student = new Student("first", "last", Grade.Second);
            var teacher = new Teacher("Gosho","OtPochivka",Subject.Bulgarian);
            var marksCount = student.Marks.Count;

            teacher.AddMark(student, 3);

            Assert.That(marksCount + 1 == student.Marks.Count);
        }

    }
}
