namespace Abstract_Factory.Classes
{
    using System;
    using System.Linq;

    using Abstract_Factory.Classes.Products;
    public abstract class SweetsFactory
    {
        public abstract Sweet CreateChocolate();
        public abstract Sweet CreateIceCream();
    }
}
