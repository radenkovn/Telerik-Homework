namespace Builder.Classes
{
    using System;
    
    using Builder.Classes.Products;

    public abstract class ChocolateBuilder
    {
        public Chocolate Chocolate { get; set; }

        public abstract void SetMilkType();
        public abstract void SetChocolateType();
        public abstract void SetWidth();
        public abstract void SetHeight();
        public abstract void SetWeight();
        public abstract void SetBrand();
    }
}
