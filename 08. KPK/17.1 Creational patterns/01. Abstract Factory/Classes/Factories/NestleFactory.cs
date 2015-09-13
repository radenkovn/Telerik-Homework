namespace Abstract_Factory.Classes.Factories
{
    using System;
    using System.Linq;

    using Abstract_Factory.Classes.Products;
    class NestleFactory : SweetsFactory
    {
        public override Sweet CreateChocolate()
        {
            var nestleChocolate = new Chocolate("nestle");
            nestleChocolate.Add("milk");
            return nestleChocolate;
        }

        public override Sweet CreateIceCream()
        {
            var nestleIceCream = new IceCream("snickers");
            nestleIceCream.Add("milk");
            nestleIceCream.Add("peanuts");
            return nestleIceCream;
        }
    }
}
