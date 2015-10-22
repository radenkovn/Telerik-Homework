namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses.Classes;
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void ExpectAddingStudentsToSchoolToAddThemCorrectly()
        {
            var school = new School();
            var billy = new Student("Billy", 10000);

            school.AddStudent(billy);
            Assert.AreEqual(school.Students[0], billy, "Expect the add method to add valid students correctly");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectAddStudentToSchoolToThrowWhenAddingADuplicatedID()
        {
            var school = new School();
            var billy = new Student("Billy", 10000);
            var willy = new Student("Willy", 10000);

            school.AddStudent(billy);
            school.AddStudent(willy);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectAddStudentToSchoolToThrowWhenAddingANullValue()
        {
            var school = new School();
            school.AddStudent(null);
        }
        [TestMethod]
        public void ExpectRemoveStudentInSchoolToRemoveAnAddedStudent()
        {
            var school = new School();
            var billy = new Student("Billy", 10000);
            school.AddStudent(billy);
            school.RemoveStudent(billy);

            Assert.AreEqual(school.Students.Count, 0, "Expects the students list to be empty");
        }
        [TestMethod]
        public void ExpectAddCourseToAddTheCourse()
        {
            var school = new School();
            var course = new Course();
            var billy = new Student("Billy", 10000);
            course.AddStudent(billy);

            school.AddCourse(course);

            Assert.AreEqual(school.Courses[0], course, "Expected the school to have an added course");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectAddCourseToSchoolToThrowWhenAddingANullValue()
        {
            var school = new School();
            school.AddCourse(null);
        }
        [TestMethod]
        public void ExpectRemoveCourseToRemoveTheCourse()
        {
            var school = new School();
            var course = new Course();
            var billy = new Student("Billy", 10000);
            course.AddStudent(billy);

            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.AreEqual(school.Courses.Count, 0, "Expected the school to have an empty course list");
        }

    }
}
