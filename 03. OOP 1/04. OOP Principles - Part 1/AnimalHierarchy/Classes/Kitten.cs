using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Classes
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, false)
        {
            this.sound = "MEW";
        }
    }
}
