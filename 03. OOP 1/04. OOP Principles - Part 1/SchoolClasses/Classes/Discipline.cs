namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Discipline
    {
        private string name;
        private int numberLectures;
        private int numberExercises;
        public Discipline(string name, int numberLectures, int numberExercises)
        {
            this.Name = name;
            this.NumberLectures = numberLectures;
            this.NumberExercises = numberExercises;
        }
        //Discipline name
        public string Name { get { return this.name; } private set { this.name = value; } }
        //Discipline number of lectures
        public int NumberLectures { get { return this.numberLectures; } set { this.numberLectures = value; } }
        //Discipline number of exercises    
        public int NumberExercises { get { return this.numberExercises; } set { this.numberExercises = value; } }
        public override string ToString()
        {
            return string.Format("{0} - {1} lectures, {2} exercises", this.Name, this.NumberLectures, this.NumberExercises);
        }
    }
}
