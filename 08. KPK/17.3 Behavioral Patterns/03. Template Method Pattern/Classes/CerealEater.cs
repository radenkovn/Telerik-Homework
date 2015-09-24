namespace TemplateMethod.Classes
{
    using System;

    public abstract class CerealEater
    {
        public void Eat()
        {
            GetPlate();
            AddMilk();
            HeatMilk();
            AddCereal();
        }
        public void GetPlate()
        {
            Console.WriteLine("I found a plate. I'm ready to eat!");
        }
        public void AddMilk()
        {
            Console.WriteLine("I went to the fridge and got the milk!");
        }
        public abstract void HeatMilk();
        public abstract void AddCereal();
    }
}
