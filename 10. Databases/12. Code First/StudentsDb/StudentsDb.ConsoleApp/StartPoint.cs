namespace StudentsDb.ConsoleApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Data;
    using Data.Migrations;
    using Model;

    public class StartPoint
    {
        public static void Main()
        {
            Console.WriteLine("THE NAME OF THE DATABASE IS StudentsDb");


            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsContext, Configuration>());

            var db = new StudentsContext();

            CreateSampleHomeworks(db);

            var studentNames = db.Students.Select(s => new { s.Name, Homeworks = s.Homeworks.Select(x => x.Content).ToList() }).ToList();

            foreach (var s in studentNames)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(string.Join(", ", s.Homeworks));
            }

        }
        public static void CreateSampleHomeworks(StudentsContext db)
        {
            var homework1 = new Homework
            {
                Content = "Study this",
                Student = db.Students.FirstOrDefault(x => x.Name == "Harry Potter"),
                Course = db.Courses.FirstOrDefault(x => x.Name == "Alchemy")

            };

            var homework2 = new Homework
            {
                Content = "Very easy",
                Student = db.Students.FirstOrDefault(x => x.Name == "Hermione"),
                Course = db.Courses.FirstOrDefault(x => x.Name == "Dark arts")
            };

            db.Homeworks.Add(homework1);
            db.Homeworks.Add(homework2);
            db.SaveChanges();
        }
    }
}
