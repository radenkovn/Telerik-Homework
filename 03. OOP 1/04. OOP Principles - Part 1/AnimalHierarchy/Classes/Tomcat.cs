using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Classes
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
            this.sound = "MEOWR";
        }
    }
}
