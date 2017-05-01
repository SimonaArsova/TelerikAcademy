using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    struct Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public static Point3D getPointO
        {
            get
            {
                return pointO;
            }
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
