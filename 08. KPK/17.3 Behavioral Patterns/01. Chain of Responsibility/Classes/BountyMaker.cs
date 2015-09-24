namespace Chain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class BountyMaker : ChocolateMaker
    {
        public override void Create(Chocolate chocolate)
        {
            if (chocolate.MainIngredienet == "cocoa")
            {
                Console.WriteLine("Bounty Created - {0}",chocolate.ListIngredients());
            }
            else if(this.Maker!=null)
            {
                this.Maker.Create(chocolate);
            }
        }
    }
}
