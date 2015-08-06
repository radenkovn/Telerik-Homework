using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Classes
{
    abstract class Animal : ISound
    {
        private int age;
        private string name;
        private bool sex;
        protected string sound;
        public Animal(string name, int age, bool sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public int Age { get { return this.age; } protected set { this.age = value; } }
        public string Name { get { return this.name; } protected set { this.name = value; } }
        public bool Sex { get { return this.sex; } protected set { this.sex = value; } }
        public string Sound()
        {
            return string.Format("{0} says {1}!", this.Name, this.sound);
        }
        public static double AverageAge(Animal[] animals)
        {
            double averageAge = animals.Average(x => x.Age);
            return averageAge;
        }
        public override string ToString()
        {
            string gender;
            if(this.sex == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            return string.Format("{0} - {1} - {2}", this.Name, this.Age, gender);
        }
    }
}
