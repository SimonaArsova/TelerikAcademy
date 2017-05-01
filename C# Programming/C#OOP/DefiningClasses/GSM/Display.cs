using System;

namespace DefiningClasses
{
    public class Display
    {
        private double size = 0.0;
        private int numberOfColors = 0;

        public Display() { }
        
        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size can't be negative!");
                }
                size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors can't be negative!");
                }
                numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Display size: {0}\nNumber of colors: {1}", Size, NumberOfColors);
        }
    }
}
