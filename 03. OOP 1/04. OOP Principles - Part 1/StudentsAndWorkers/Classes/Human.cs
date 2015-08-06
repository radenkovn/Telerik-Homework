namespace StudentsAndWorkers.Classes
{
    using System;
    abstract class Human
    {
        private string firstName;
        private string secondName;
        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
        public string FirstName { get { return this.firstName; } protected set { this.firstName = value; } }
        public string SecondName { get { return this.secondName; } protected set { this.secondName = value; } }
    }
}
