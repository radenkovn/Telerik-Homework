namespace Composite.Classes
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

        public override string ListIngredients()
        {
            return this.Name + "- Chocolate - Ingredients: " + string.Join(" ", this.Ingredients.ToArray());
        }
    }
}
