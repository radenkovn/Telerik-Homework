namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses.Classes;
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ExpectStudentToHaveValidNameAndID()
        {
            var student = new Student("Billy", 12394);
            var expectedName = "Billy";
            var expectedID = 12394;
            Assert.AreEqual(student.Name, expectedName, "Expected the student to have the correct name");
            Assert.AreEqual(student.Id, expectedID, "Expected the student to have the correct ID");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectStudentToThrowWhenInitiatedWithASmallID()
        {
            var student = new Student("Billy", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectStudentToThrowWhenInitiatedWithABigID()
        {
            var student = new Student("Billy", 200000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectStudentToThrowWhenInitiatedWithEmptyName()
        {
            var student = new Student(" ", 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectStudentToThrowWhenChangedToAnEmptyName()
        {
            var student = new Student("Billy", 10001);
            student.Name = " ";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectStudentToThrowWhenChangedToAnSmallID()
        {
            var student = new Student("Billy", 10001);
            student.Id = 5;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectStudentToThrowWhenChangedToAnBigID()
        {
            var student = new Student("Billy", 10001);
            student.Id = 102938905;
        }
    }
}
