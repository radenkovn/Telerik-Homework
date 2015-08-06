namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Person
    {
        private List<Discipline> disciplines;
        public Teacher(string name):base(name)
        {
            this.Disciplines = new List<Discipline>();
        }
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Discipline> Disciplines { get { return this.disciplines; } private set { this.disciplines = value; } }
        // A method do add a discipline
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
        // A method do remove a discipline
        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
        public override string ToString()
        {
            return string.Format("{0}\n{1}", this.Name, string.Join(", ", this.Disciplines));
        }
    }
}
