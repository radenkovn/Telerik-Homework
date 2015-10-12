namespace Builder.Classes.Director
{
    using Builder.Classes;
    using Builder.Classes.Products;

    class ChocolateDirector
    {
        public Chocolate CreateChocolate()
        {
            ChocolateBuilder builder = new MilkaBuilder();
            builder.Chocolate = new Chocolate();
            builder.SetBrand();
            builder.SetMilkType();
            builder.SetChocolateType();
            builder.SetWidth();
            builder.SetHeight();
            builder.SetWeight();
            return builder.Chocolate;
        }
    }
}
