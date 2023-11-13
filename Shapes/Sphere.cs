using System;
namespace shape_area.Shapes
{
	public class Sphere
	{
        const double PI = Math.PI;
        private double Radius { get; set; }

        public Sphere()
        {
        }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return (4 * PI * (Radius * Radius));
        }
    }
}

