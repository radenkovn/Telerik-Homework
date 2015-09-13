namespace Abstract_Factory.Classes.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Chocolate : Sweet
    {
        public Chocolate(string name)
            : base(name)
        {
            this.Ingredients.Add("cacao");
        }
    }
}
