namespace _09.Student_groups
{
    using _09.Student_groups.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MainFunc
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Georgi", "Georgiev",  "3131205", "02 8484849", "georgi@abv.bg",    new List<int>(new int[] { 4, 5, 6, 3 }), 2));
            students.Add(new Student("Pesho",  "Petrov",    "3242205", "052 938849", "pesho@gmail.bg",   new List<int>(new int[] { 4, 2, 5, 3 }), 1));
            students.Add(new Student("Mitko",  "Dimitrov",  "3251206", "044 472483", "mitko@abv.bg",     new List<int>(new int[] { 6, 5, 2, 2 }), 3));
            students.Add(new Student("Dragan", "Draganov",  "3131206", "02 8758299", "dragan@yahoo.bg",  new List<int>(new int[] { 6, 2, 3, 3 }), 2));
            students.Add(new Student("Hristo", "Botev",     "3131205", "087 484849", "hristo@msn.bg",    new List<int>(new int[] { 2, 3, 4, 5 }), 3));

            //Problem 9
            //Use LINQ query. Order the students by FirstName.
            Console.WriteLine("In group 2\n");
            var orderedGrp2 = from st in students
                              where (st.GroupNumber == 2)
                              orderby st.FirstName
                              select st;
            PrintColl(orderedGrp2);

            //Problem 10
            //Implement the previous using the same query expressed with extension methods.
            Console.WriteLine("\nIn group 2 using Extension\n");
            var usingExtMeth = students.Where(x => x.GroupNumber == 2)
                                    .OrderBy(x => x.FirstName);
            PrintColl(usingExtMeth);

            //Problem 11
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            Console.WriteLine("\nStudens with emails in abv.bg\n");
            //var abvStudents = students.Where(x => x.Email.Contains("@abv.bg"));
            var abvStudents = from st in students
                              where st.Email.Contains("@abv.bg")
                              select st;
            PrintColl(abvStudents);

            //Problem 12
            //Extract all students with phones in Sofia.
            Console.WriteLine("\nStudents with phones in Sofia\n");
            //var sofiaStudents = students.Where(x => x.Tel.StartsWith("02"));
            var sofiaStudents = from st in students
                                where st.Tel.StartsWith("02")
                                select st;

            PrintColl(sofiaStudents);

            //Problem 13 
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            Console.WriteLine("\nStudents containing a grade 6\n");
            //var excellentStsud = students.Where(x => x.Marks.Contains(2))
            //                .Select(x => new { FullName = x.ToString(), Marks = x.Marks });

            var excellentStud = from st in students
                                where st.Marks.Contains(6)
                                select new { FullName = st.ToString(), Marks = st.Marks };
            foreach (var student in excellentStud)
            {
                Console.WriteLine("Full name: {0}, Marks: ", student.FullName);
            }

            //Problem 14
            //Write down a similar program that extracts the students with exactly two marks "2".
            Console.WriteLine("\nStudents containing a grade 2\n");
            var twoStud = students.Where(x => x.Marks.Contains(2))
                                        .Select(x => new { FullName = x.ToString(), Marks = x.Marks });
            foreach (var student in twoStud)
            {
                Console.WriteLine("Full name: {0}, Marks: ", student.FullName);
            }

            //Problem 15
            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("\nMarks of students who enrolled in 2006\n");
            var twoKSixStud = students.Where(x => x.FN.Substring(5, 2) == "06")
                                        .Select(x => x.Marks);
            foreach (var marks in twoKSixStud)
            {
                foreach (var mark in marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }

            //Problem 18
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            Console.WriteLine("\nAll students grouped by GroupNumber using query\n");
            var groupedByGN = from st in students
                              group st by st.GroupNumber;
            foreach (var group in groupedByGN)
            {
                foreach (var st in group)
                {
                    Console.WriteLine("{0} - {1} group", st, st.GroupNumber);
                }
                Console.WriteLine();
            }

            //Problem 19
            //Rewrite the previous using extension methods.
            Console.WriteLine("\nAll students grouped by GroupNumber using ext meth\n");
            var groupExtMeth = students.GroupBy(x => x.GroupNumber);
            foreach (var group in groupedByGN)
            {
                foreach (var st in group)
                {
                    Console.WriteLine("{0} - {1} group", st, st.GroupNumber);
                }
                Console.WriteLine();
            }
        }
        public static void PrintColl<T>(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
