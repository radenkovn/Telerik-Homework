namespace Composite.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SweetsBox : Sweet
    {
        private IList<Sweet> sweets;
        public SweetsBox(string name)
            : base(name)
        {
            this.sweets = new List<Sweet>();
        }

        public void AddSweet(Sweet sweet)
        {
            this.sweets.Add(sweet);
        }
        public void RemoveSweet(Sweet sweet)
        {
            this.sweets.Remove(sweet);
        }
        public override string ListIngredients()
        {
            StringBuilder sweetsBuilder = new StringBuilder(this.Name + "\n");
            foreach (var sweet in this.sweets)
            {
                sweetsBuilder.Append(sweet.ListIngredients() + "\n");
            }
            return sweetsBuilder.ToString();
        }
    }
}
