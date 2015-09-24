namespace Chain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Svoge : ChocolateMaker
    {
        public override void Create(Chocolate chocolate)
        {
            Console.WriteLine("Random Svoge Created - {0}, enjoy!", chocolate.ListIngredients());
        }
    }
}
