namespace ClassSize
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        /// <summary>
        /// The method calculates the new size after of rotation by N degrees
        /// </summary>
        /// <returns>The new size after the rotation</returns>
        public static Size GetRotatedSize(Size size, double figureAngle)
        {
            double dimensionCos = Math.Abs(Math.Cos(figureAngle)) * size.Width;
            double dimensionSin = Math.Abs(Math.Sin(figureAngle)) * size.Height;

            double width = dimensionCos + dimensionSin;
            double height = dimensionCos + dimensionSin;

            return new Size(width, height);
        }
    }
}
