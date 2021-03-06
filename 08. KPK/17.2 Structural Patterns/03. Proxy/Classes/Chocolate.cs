﻿namespace Proxy.Classes
{
    using System;
    using System.Linq;
    public class Chocolate : IChocolate
    {
        private string chocolateType;
        private string milkTYpe;
        private string width;
        private string height;
        private string weight;
        private string brand;

        public string ChocolateType
        {
            get
            {
                return this.chocolateType;
            }
            set
            {
                this.chocolateType = value;
            }
        }

        public string MilkTYpe
        {
            get
            {
                return this.milkTYpe;
            }
            set
            {
                this.milkTYpe = value;
            }
        }

        public string Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public string Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public string Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }

    }
}
