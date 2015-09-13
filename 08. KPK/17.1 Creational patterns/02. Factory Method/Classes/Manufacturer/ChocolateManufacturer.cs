namespace Factory_Method.Classes
{
    using System;
    using System.Linq;

    using Factory_Method.Classes.Products;
    public abstract class ChocolateManufacturer
    {
        private Chocolate chocolate;
        public abstract void AddIngredients();

        public Chocolate Chocolate
        {
            get
            {
                return this.chocolate;
            }
            set
            {
                this.chocolate = value;
            }
        }
    }
}
