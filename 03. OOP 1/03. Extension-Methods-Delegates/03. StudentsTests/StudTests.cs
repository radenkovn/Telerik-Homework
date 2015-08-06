namespace StudentsTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentsTests.Classes;

    class StudTests
    {
        static void Main()
        {
            Student[] studArr = {   new Student("Pesho", "Georgiev", 19),
                                    new Student("Gosho", "Petrov", 15),
                                    new Student("Tosho", "Georgiev", 13),
                                    new Student("Georgi", "Todorov", 20),
                                    new Student("Georgi", "Georgiev", 20),
                                    new Student("Ivan", "Ivanov", 12),};
            //Problem 3
            Console.WriteLine("First before last");
            foreach (var item in Student.FirstBeforeLast(studArr))
            {
                Console.WriteLine(item);
            }
            //Problem 4
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var studentsList = from student in studArr 
                               where (student.Age > 18 && student.Age < 24) 
                               select student;
            Console.WriteLine("Between 18 and 24:");
            foreach (var stud in studentsList)
            {
                Console.WriteLine(stud);
            }

            //Problem 5
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order
            var descendingList = studArr.OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Reverse()
                .Select(x=> x.FirstName + " " + x.LastName);
            Console.WriteLine("Ordered descending:");
            foreach (var stud in descendingList)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("Ordered descending with query:");
            var descList = from st in studArr
                           orderby st.FirstName descending, st.LastName descending
                           select st.FirstName + " " + st.LastName;
            foreach (var st in descList)
            {
                Console.WriteLine(st);
            }
                           
        }

    }
}
