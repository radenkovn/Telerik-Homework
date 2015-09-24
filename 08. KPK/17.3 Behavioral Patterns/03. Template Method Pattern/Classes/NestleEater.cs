namespace TemplateMethod.Classes
{
    using System;

    public class NestleEater: CerealEater
    {
        public override void HeatMilk()
        {
            Console.WriteLine("I like my milk cold!");
        }

        public override void AddCereal()
        {
            Console.WriteLine("I added some Cheerios and Nesquik. Wow!");
        }
    }
}
