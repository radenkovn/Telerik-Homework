namespace StudentsAndCourses.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses.Classes;
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void ExpectCourseToAddAStudent()
        {
            var course = new Course();
            var billy = new Student("Billy",10000);
            course.AddStudent(billy);

            Assert.AreSame(billy, course.getStudents[0],"Expects the student inside the course to be the same");
        }
        [TestMethod]
        public void ExpectCourseToRemoveStudent()
        {
            var course = new Course();
            var billy = new Student("Billy", 10000);
            course.AddStudent(billy);
            course.RemoveStudent(course.getStudents[0]);

            Assert.AreEqual(course.getStudents.Count,0,"Expects the students list to be empty");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExpectAddMethodToThrowWhenAddingMoreThan30Students()
        {
            var course = new Course();
            for (int i = 0; i <= 30; i++)
            {
                var billy = new Student("Billy"+i, 10000+i);
                course.AddStudent(billy);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectAddMethodToThrowWhenAddingNull()
        {
            var course = new Course();
            course.AddStudent(null);
        }
    }
}
