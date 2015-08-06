namespace InheritanceAndPolymorphism.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;
        public Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                NameValidator(value);
                this.name = value;
            }
        }
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                NameValidator(value);
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        protected virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
        private void NameValidator(string name)
        {
            if (name == null || name.Trim().Length < 1)
            {
                throw new ArgumentNullException("A course or teacher name cannot have less than a letter");
            }
        }

        private void StudentsListValidator(IList<string> students)
        {
            if (students == null || students.Count == 0)
            {
                throw new ArgumentNullException("A course cannot be empty");
            }
            foreach (var student in students)
            {
                NameValidator(student);
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }
    }
}
