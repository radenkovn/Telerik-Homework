﻿namespace Abstract_Factory.Classes.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Sweet
    {
        private IList<string> ingredients;
        private string name;
        protected Sweet(string name)
        {
            this.Name = name;
            this.Ingredients = new List<string>();
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
        public override string ToString()
        {
            return this.name + " - Ingredients: " + string.Join(" ", this.Ingredients.ToArray());
        }
    }
}
