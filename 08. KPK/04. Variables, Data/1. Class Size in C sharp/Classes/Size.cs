namespace ClassSize.Classes
{
    using System;
    public class Size
    {
        private double width;
        private double height;
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static Size GetRotatedSize(Size size, double rotationFigureAngle)
        {
            double rotationAngleCos = Math.Abs(Math.Cos(rotationFigureAngle));
            double rotationAngleSin = Math.Abs(Math.Sin(rotationFigureAngle));
            double rotationFigureWidth = rotationAngleCos * size.Width + rotationAngleSin * size.Height;
            double rotationFigureHeight = rotationAngleSin * size.Width + rotationAngleCos * size.Height;

            return new Size(rotationFigureWidth, rotationFigureHeight);
        }

        public double Width
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

        public double Height
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
    }
}
