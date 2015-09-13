namespace Factory_Method.Classes
{
    using System;
    using System.Linq;
    using Factory_Method.Classes.Products;

    class MilkaManufacturer : ChocolateManufacturer
    {
        public override void AddIngredients()
        {
            this.Chocolate = new Milka("Purple");
            this.Chocolate.Add("biscuits");
            this.Chocolate.Add("corn");
        }
    }
}
