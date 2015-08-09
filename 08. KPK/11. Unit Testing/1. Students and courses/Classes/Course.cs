namespace StudentsAndCourses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Course
    {
        private const int maximumStudentCount = 30;
        private IList<Student> studentSet;
        public Course()
        {
            this.studentSet = new List<Student>();
        }
        public IList<Student> getStudents
        {
            get
            {
                return this.studentSet.Select(x=>x).ToList();
            }
        }
        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("You cannot have a null student added to the course");
            }
            if (this.studentSet.Count == maximumStudentCount)
            {
                throw new ArgumentOutOfRangeException(string.Format("The students in a course cannot be more than {0}", maximumStudentCount));
            }
            studentSet.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            studentSet.Remove(student);
        }
    }
}
