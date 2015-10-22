namespace StudentsDb.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentsContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentsDb.Data.StudentsContext";
        }

        protected override void Seed(StudentsContext context)
        {
            context.Students.AddOrUpdate(
                x => x.Name,
                new Student
                {
                    Id = 1123,
                    Name = "Harry Potter",
                    Number = 123
                },
                new Student
                {
                    Id = 1123,
                    Name = "Hermione",
                    Number = 124
                });

            context.Courses.AddOrUpdate(
                x => x.Name,
                new Course
                {
                    Name = "Alchemy",
                    Materials = "Pots",
                    Description = "Very interesting"
                },
                new Course
                {
                    Name = "Dark arts",
                    Materials = "Scary",
                    Description = "Very scary"
                });
        }
    }
}
