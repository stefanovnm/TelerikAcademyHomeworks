using System;

using Moq;
using NUnit.Framework;
using SchoolSystem.Models;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class MarkClassTests
    {
        [Test]
        public void Mark_Constructor_ShouldReturnObjectWithClassMark()
        {
            Assert.IsInstanceOf<Mark>(new Mark(Subject.Bulgarian, 3));
        }

        [TestCase(7)]
        [TestCase(-1)]
        public void Mark_ShouldThrowException_WhenMarkIsNotInRange2To6(float expectedValue)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Mark(Subject.Bulgarian, expectedValue));
        }

        [TestCase(3)]
        [TestCase(5)]
        public void Mark_ShouldNotThrow_AndHaveValue(float expectedValue)
        {
            var mark = new Mark(Subject.Bulgarian, expectedValue);

            Assert.That(expectedValue == mark.Value);
        }
    }
}
