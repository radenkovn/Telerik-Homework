namespace Abstract_Factory.Classes.Factories
{
    using System;
    using System.Linq;

    using Abstract_Factory.Classes.Products;
    class SvogeFactory : SweetsFactory
    {
        public override Sweet CreateChocolate()
        {
            var svogeChocolate = new Chocolate("nestle");
            svogeChocolate.Add("strawberry");
            return svogeChocolate;
        }

        public override Sweet CreateIceCream()
        {
            var svogeIceCream = new IceCream("snickers");
            svogeIceCream.Add("kiwi");
            return svogeIceCream;
        }
    }
}
