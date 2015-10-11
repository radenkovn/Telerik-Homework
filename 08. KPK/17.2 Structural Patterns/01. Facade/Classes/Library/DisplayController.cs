namespace Facade.Classes.Library
{
    using System;
    using System.Linq;
    public class DisplayController
    {
        public DisplayController()
        {

        }
        public void LoadIntro()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome to Sowny Playstation");
            Console.WriteLine("----------------------------");
        }
        public void DisplayMediaName(string name)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Playing {0}", name);
            Console.WriteLine("----------------------------");
        }
        public void LoadOutro()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Have a nice day. Make sure to come back");
            Console.WriteLine("---------------------------------------");
        }
    }
}
