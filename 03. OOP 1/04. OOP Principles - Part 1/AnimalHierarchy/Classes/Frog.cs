using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Classes
{
    class Frog : Animal
    {
        public Frog(string name, int age, bool sex)
            : base(name, age, sex)
        {
            this.sound = "QUACK";
        }
        public void Jump()
        {
            Console.WriteLine("{0} Jumps, {1}", this.Name, base.Sound());
        }
    }
}
