namespace Builder.Classes
{
    using System;
    using System.Linq;

    class MilkaBuilder : ChocolateBuilder
    {
        public override void SetMilkType()
        {
            this.Chocolate.MilkTYpe = "cow";
        }

        public override void SetChocolateType()
        {
            this.Chocolate.ChocolateType = "milk";
        }

        public override void SetWidth()
        {
            this.Chocolate.Width = "20 cm";
        }

        public override void SetHeight()
        {
            this.Chocolate.Height = "10 cm";
        }

        public override void SetWeight()
        {
            this.Chocolate.Weight = "100g";
        }

        public override void SetBrand()
        {
            this.Chocolate.Brand = "Milka";
        }
    }
}
