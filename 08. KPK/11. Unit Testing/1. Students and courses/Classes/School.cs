namespace StudentsAndCourses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class School
    {
        private IList<Student> students;
        private IList<Course> courses;

        public School()
        {
            this.students = new List<Student>();
            this.courses = new List<Course>();
        }

        public IList<Student> Students
        {
            get
            {
                return this.students.Select(x => x).ToList();
            }
        }

        public IList<Course> Courses
        {
            get
            {
                return this.courses.Select(x=>x).ToList();
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("You cannot have a student with a null value added to the school!");
            }
            if (this.students.Any(x => x.Id == student.Id))
            {
                throw new ArgumentException("You cannot have students with the same ID in a school");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }
        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("You cannot have a course with a null value added to the school!");
            }
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            this.courses.Remove(course);
        }
    }
}
