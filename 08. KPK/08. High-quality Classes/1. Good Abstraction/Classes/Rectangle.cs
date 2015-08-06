namespace Abstraction.Classes
{
    using System;

    using Abstraction.Interfaces;
    class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle()
        {
            this.Width = 0;
            this.Height = 0;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                ValidateSegment(value);
                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                ValidateSegment(value);
                this.height = value;
            }
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
        private void ValidateSegment(double length)
        {
            if (length <= 0)
            {
                throw new ArgumentNullException("A rectangle segment cannot have a negative or zero value!");
            }
        }
    }
}