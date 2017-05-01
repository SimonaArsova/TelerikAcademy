using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Startup
    {
        static void Main()
        {
            Triangle triangle = new Triangle(3, 5);
            Rectangle rectangle = new Rectangle(2, 4);
            Square square = new Square(5);

            Shape[] shapes = { triangle, rectangle, square };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
