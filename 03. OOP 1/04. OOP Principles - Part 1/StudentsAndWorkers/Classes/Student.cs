namespace StudentsAndWorkers.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student : Human
    {
        private int grade;
        //public Student(string firstName, string secondName)
        //    : base(firstName, secondName)
        //{

        //}
        public Student(string firstName, string secondName, int grade)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }
        public int Grade { get { return this.grade; } set { this.grade = value; } }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} - {2}", this.FirstName, this.SecondName, this.Grade);
        }
    }
}
