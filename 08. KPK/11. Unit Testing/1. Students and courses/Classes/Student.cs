namespace StudentsAndCourses.Classes
{
    using System;
    public class Student
    {
        private const int minimumIdValue = 10000;
        private const int maximumIdValue = 99999;
        private string name;
        private double id;

        public Student(string name, double id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentNullException("The name of a student cannot be empty!");
                }
                this.name = value;
            }
        }
        public double Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < minimumIdValue || value > maximumIdValue)
                {
                    throw new ArgumentException(string.Format("The ID of a student cannot be less than {0} or greater than {1}", minimumIdValue, maximumIdValue));
                }
                this.id = value;
            }
        }
    }
}
