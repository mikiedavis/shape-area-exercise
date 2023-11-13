using System;
namespace shape_area.Shapes
{
	public class Triangle
	{
        private double Height { get; set; }
        private double Width { get; set; }

		public Triangle()
		{
		}

        public Triangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return (Height * Width) / 2;
        }
    }
}

