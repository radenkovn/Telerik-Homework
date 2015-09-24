namespace Chain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class ChocolateMaker
    {
        protected ChocolateMaker Maker { get; set; }
        public void SetMaker(ChocolateMaker maker)
        {
            this.Maker = maker;
        }
        public abstract void Create(Chocolate chocolate);
    }
}
