namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentsAndWorkers.Classes;
    class StartProgram
    {
        static void Main()
        {
            List<Student> students = new List<Student>() { new Student("Ivan", "Ivanov", 100), 
                                                           new Student("Georgi", "Georgiev", 54), 
                                                           new Student("Maria", "Marieva", 77), 
                                                           new Student("John", "Snow", 87), 
                                                           new Student("Brad", "Pitt", 28), 
                                                           new Student("Grigor", "Dimitrov", 45), 
                                                           new Student("Ivan", "Vazov", 98), 
                                                           new Student("Hristo", "Botev", 48),
                                                           new Student("Petur", "Petrov", 72), 
                                                           new Student("Martin", "Martinov", 66), };
            var orderedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine("Ordered Students\n");
            foreach (var stud in orderedStudents)
            {
                Console.WriteLine(stud);
            }

            List<Worker> workers = new List<Worker>() {    new Worker("Ivan", "Todorov", 1052.6m, 40), 
                                                           new Worker("Georgi", "Rakovski", 800m, 25), 
                                                           new Worker("Teodora", "Ivanova", 300.12m, 40), 
                                                           new Worker("Harry", "Potter", 400, 50), 
                                                           new Worker("Ronald", "Weasley", 550, 35), 
                                                           new Worker("Grigor", "Potter", 2154, 20), 
                                                           new Worker("Parry", "Potter", 404, 25), 
                                                           new Worker("Dimitar", "Mitkov", 350, 40),
                                                           new Worker("Peter", "Pan", 950, 30), 
                                                           new Worker("Ellen", "Page", 250, 35), };

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("\nOrdered Workers\n");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }

            List<Human> humans = new List<Human>();
            foreach (var student in orderedStudents)
            {
                humans.Add(student);
            }
            foreach (var worker in orderedWorkers)
            {
                humans.Add(worker);
            }
            var sortedHumans = humans.OrderBy(x => x.SecondName)
                                     .ThenBy(x => x.FirstName);
            Console.WriteLine("\nSorted humans\n");
            foreach (var human in sortedHumans)
            {
                Console.WriteLine("{0,-10} {1,-10}", human.FirstName, human.SecondName);
            }
            Console.WriteLine();
        }
    }
}
