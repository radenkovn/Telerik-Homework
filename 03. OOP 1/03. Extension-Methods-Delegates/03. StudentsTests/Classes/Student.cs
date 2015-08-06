namespace StudentsTests.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            return string.Format("First name: {0}, Last Name: {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
        //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
        public static Student[] FirstBeforeLast(Student[] input)
        {
            //Student[] studArrOrdered = input.Where(x => x.FirstName.CompareTo(x.LastName) <0).ToArray();
            var studArrOrdered = from student in input 
                                 where student.FirstName.CompareTo(student.LastName) < 0 
                                 select student;
            var result = studArrOrdered.ToArray();
            //return result;
            return result;
        }
    }
}
