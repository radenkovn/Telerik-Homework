namespace Proxy.Classes
{
    using System;
    public class MilkaProxy : IChocolate
    {
        private Chocolate chocolate;

        private void CreateChocolate()
        {
            if (this.chocolate == null)
            {
                this.chocolate = new Chocolate();
            }
        }

        public string ChocolateType
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.ChocolateType;
            }
            set
            {
                if (value == "milky")
                {
                    this.CreateChocolate();
                    this.chocolate.ChocolateType = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate likes to be milky!");
                }
            }
        }

        public string MilkTYpe
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.MilkTYpe;
            }
            set
            {
                if (value == "cow")
                {
                    this.CreateChocolate();
                    this.chocolate.MilkTYpe = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate likes to be made from cow milk!");
                }
            }
        }

        public string Width
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.Width;
            }
            set
            {
                if (value == "20")
                {
                    this.CreateChocolate();
                    this.chocolate.Width = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate likes to have a 20 cm width!");
                }
            }
        }

        public string Height
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.Height;
            }
            set
            {
                if (value == "10")
                {
                    this.CreateChocolate();
                    this.chocolate.Height = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate likes to have a 10 cm height!");
                }
            }
        }

        public string Weight
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.Weight;
            }
            set
            {
                if (value == "100")
                {
                    this.CreateChocolate();
                    this.chocolate.Weight = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate likes to have a 100g weight!");
                }
            }
        }

        public string Brand
        {
            get
            {
                this.CreateChocolate();
                return this.chocolate.Brand;
            }
            set
            {
                if (value == "Milka")
                {
                    this.CreateChocolate();
                    this.chocolate.Brand = value;
                }
                else
                {
                    Console.WriteLine("Milka chocolate's brand is obviously Milka!");
                }
            }
        }
    }
}
