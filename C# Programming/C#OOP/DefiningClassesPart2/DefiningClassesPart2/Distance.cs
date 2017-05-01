using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                    (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                    (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));

            return distance;
        }
    }
}
