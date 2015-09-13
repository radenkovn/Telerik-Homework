namespace Abstract_Factory.Classes.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class IceCream : Sweet
    {
        public IceCream(string name)
            :base(name)
        {
            this.Ingredients.Add("cream");
        }
    }
}
