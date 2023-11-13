using System;
namespace shape_area.Shapes
{
	public class Circle
	{
        const double PI = Math.PI;
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return PI * (Radius * Radius);
        }
    }
}

