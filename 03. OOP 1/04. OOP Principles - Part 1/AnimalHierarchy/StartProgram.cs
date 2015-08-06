using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Classes;

namespace AnimalHierarchy
{
    class StartProgram
    {
        static void Main()
        {
            Animal[] animals = { new Cat("Cat", 15, true), 
                               new Dog("Doge", 13, false),
                               new Frog("Froge", 12, true),
                               new Kitten("Kitten", 18),
                               new Tomcat("Tomcat", 20),
                               new Cat("Cat2", 10, false),
                               new Dog("Doge2", 5, true),
                               new Frog("Froge", 4, false),
                               new Kitten("Kitten", 8),
                               new Tomcat("Tomcat", 4),
                               new Cat("Cat2", 5, false),
                               new Dog("Doge2", 7, false),
                               new Frog("Froge", 3, true),
                               new Kitten("Kitten", 2),
                               new Tomcat("Tomcat", 14) };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("The average age of these animals is: {0:0.00}", Animal.AverageAge(animals));
            var catAverage = Animal.AverageAge(animals.Where(x => x is Cat).ToArray());
            var dogAverage = Animal.AverageAge(animals.Where(x => x is Dog).ToArray());
            var frogAverage = Animal.AverageAge(animals.Where(x => x is Frog).ToArray());
            var kittenAverage = Animal.AverageAge(animals.Where(x => x is Kitten).ToArray());
            var tomcatAverage = Animal.AverageAge(animals.Where(x => x is Tomcat).ToArray());
            Console.WriteLine("The average age of the cats is: {0:0.00}", catAverage);
            Console.WriteLine("The average age of the dogs is: {0:0.00}", dogAverage);
            Console.WriteLine("The average age of the frogs is: {0:0.00}", frogAverage);
            Console.WriteLine("The average age of the kittens is: {0:0.00}", kittenAverage);
            Console.WriteLine("The average age of the tomcats is: {0:0.00}", tomcatAverage);
        }
    }
}
