namespace TemplateMethod.Classes
{
    using System;

    public class Kellogs : CerealEater
    {
        public override void HeatMilk()
        {
            Console.WriteLine("I like my milk warm!");
        }

        public override void AddCereal()
        {
            Console.WriteLine("I added some Froot Loops and Corn Flakes!");
        }
    }
}
