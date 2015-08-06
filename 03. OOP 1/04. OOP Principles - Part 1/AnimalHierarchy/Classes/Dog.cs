using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Classes
{
    class Dog : Animal
    {
        public Dog(string name, int age, bool sex)
            : base(name, age, sex)
        {
            this.sound = "WOOF";
        }
        public void CatchBone()
        {
            Console.WriteLine("{0} catches a bone, {1}", this.Name, base.Sound()); 
        }
    }
}
