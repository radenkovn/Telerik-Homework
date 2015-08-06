namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private string name;
        public Person(string name)
        {
            this.Name = name;
        }
        //Person name
        public string Name { get { return this.name; } protected set { this.name = value; } }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
