namespace Iterator.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Iterator.Interfaces;
    public class Chocolate : IChocolate
    {
        private IList<string> ingredients;
        private string chocolateType;
        private string milkTYpe;
        private string width;
        private string height;
        private string weight;
        private string brand;
        public Chocolate()
        {
            this.ingredients = new List<string>();
        }

        public string ChocolateType
        {
            get
            {
                return this.chocolateType;
            }
            set
            {
                this.chocolateType = value;
                this.ingredients.Add(value);
            }
        }

        public string MilkTYpe
        {
            get
            {
                return this.milkTYpe;
            }
            set
            {
                this.milkTYpe = value;
                this.ingredients.Add(value);
            }
        }

        public string Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
                this.ingredients.Add(value);
            }
        }

        public string Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
                this.ingredients.Add(value);
            }
        }

        public string Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
                this.ingredients.Add(value);
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
                this.ingredients.Add(value);
            }
        }
        public int PropertyCount
        {
            get
            {
                return this.ingredients.Count;
            }
        }


        public string this[int index]
        {
            get
            {
                return this.ingredients[index];
            }
        }

        public IIterator CreateIterator()
        {
            return new ChocolateIterator(this);
        }
    }
}
