using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass.Classes
{
    class Person
    {
        private string name;
        private int? age;
        public Person(string name)
            :this(name, null)
        {
        }
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int? Age { get { return this.age; } set { this.age = value; } }
        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name - {0}, Age not specified.", this.Name);
            }
            return string.Format("Name - {0}, Age {1}", this.Name, this.Age);
        }

    }
}
