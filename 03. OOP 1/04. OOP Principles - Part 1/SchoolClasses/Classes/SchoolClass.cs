namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SchoolClass
    {
        private string className;
        private List<Student> students;
        private List<Teacher> teachers;
        public SchoolClass(string className)
        {
            if (UniqueData.allClassNames.Contains(className))
            {
                throw new ArgumentException("There already exists a class with such a name");
            }
            UniqueData.allClassNames.Add(className);
            this.ClassName = className;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public SchoolClass(List<Student> students, List<Teacher> teachers)
        {
            this.Students = students;
            this.Teachers = teachers;
        }
        public string ClassName { get { return this.className; } set { this.className = value; } }
        public List<Student> Students { get { return this.students; } private set { this.students = value; } }
        public List<Teacher> Teachers { get { return this.teachers; } private set { this.teachers = value; } }
        //A method to add a student
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }
        //A method to remove a student
        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }
        //A method to add a teacher
        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
        //A method to remove a teacher
        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
        public override string ToString()
        {
            string result = string.Empty;
            result += "Class " + this.ClassName + "\n";
            result += "Students:\n";
            foreach (var student in this.Students)
            {
                result += student + "\n";
            }
            result += "Teachers:\n";
            foreach (var teacher in this.Teachers)
            {
                result += teacher + "\n";
            }
            return result;
        }
    }
}
