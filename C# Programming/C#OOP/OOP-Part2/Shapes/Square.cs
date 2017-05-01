﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double width) : base(width)
        {
            
        }

        public override double CalculateSurface()
        {
            return Width * Width;
        }
    }
}
