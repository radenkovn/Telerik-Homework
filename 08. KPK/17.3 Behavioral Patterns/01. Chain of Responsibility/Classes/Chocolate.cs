namespace Chain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Chocolate
    {
        private IList<string> ingredients;
        private string mainIngredient;
        private string name;
        protected Chocolate(string name, string mainIngredient)
        {
            this.Name = name;
            this.Ingredients = new List<string>();
            this.MainIngredienet = mainIngredient;
            this.Add(mainIngredient);
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string MainIngredienet
        {
            get
            {
                return this.MainIngredienet;
            }
            set
            {
                this.MainIngredienet = value;
            }
        }

        public IList<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }
            protected set
            {
                this.ingredients = value;
            }
        }

        public void Add(string product)
        {
            this.Ingredients.Add(product);
        }
        public string ListIngredients()
        {
            return string.Join(", ", this.Ingredients.ToArray());
        }
    }
}
