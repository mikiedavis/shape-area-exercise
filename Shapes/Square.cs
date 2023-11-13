using System;
namespace shape_area.Shapes
{
    public class Square : IShape
    {
        private double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public double Area()
        {
            return Length * Length;
        }
    }
}

