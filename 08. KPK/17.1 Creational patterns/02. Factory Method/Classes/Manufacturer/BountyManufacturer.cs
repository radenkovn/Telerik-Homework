namespace Factory_Method.Classes
{
    using System;
    using System.Linq;
    using Factory_Method.Classes.Products;
    class BountyManufacturer : ChocolateManufacturer
    {
        public override void AddIngredients()
        {
            this.Chocolate = new Bounty("Awesome");
            this.Chocolate.Add("cocoa");
            this.Chocolate.Add("milk");
        }
    }
}
