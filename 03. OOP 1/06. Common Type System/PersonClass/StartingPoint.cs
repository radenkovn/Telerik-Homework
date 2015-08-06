namespace PersonClass
{
    using System;

    using PersonClass.Classes;
    class StartingPoint
    {
        static void Main()
        {
            var person1 = new Person("Ivan");
            var person2 = new Person("Ivanka", 15);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
