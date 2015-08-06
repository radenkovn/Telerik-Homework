namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student : Person
    {
        private int classNumber;
        public Student(string name, int classNumber)
            : base(name)
        {
            if (UniqueData.studentNumbers.Contains(classNumber))
            {
                throw new ArgumentException("There already exists a student with such an ID");
            }
            this.ClassNumber = classNumber;
            UniqueData.studentNumbers.Add(classNumber);
        }
        public int ClassNumber { get { return this.classNumber; } set { this.classNumber = value; } }
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.ClassNumber);
        }
    
    }
}
