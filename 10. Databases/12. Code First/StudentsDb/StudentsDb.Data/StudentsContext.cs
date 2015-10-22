namespace StudentsDb.Data
{
    using System.Data.Entity;
    using Model;

    public class StudentsContext : DbContext
    {
        public StudentsContext()
            : base("StudentsDb")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }
    }
}
