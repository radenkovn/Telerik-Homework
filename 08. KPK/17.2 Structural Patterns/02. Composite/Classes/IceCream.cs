namespace Composite.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class IceCream : Sweet
    {
        public IceCream(string name)
            : base(name)
        {
            this.Ingredients.Add("cream");
        }

        public override string ListIngredients()
        {
            return this.Name + "- IceCream - Ingredients: " + string.Join(" ", this.Ingredients.ToArray());
        }
    }
}
