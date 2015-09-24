namespace Chain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MilkaMaker : ChocolateMaker
    {
        public override void Create(Chocolate chocolate)
        {
            if (chocolate.MainIngredienet == "milk")
            {
                Console.WriteLine("Milka Created - {0}", chocolate.ListIngredients());
            }
            else if (this.Maker != null)
            {
                this.Maker.Create(chocolate);
            }
        }
    }
}
