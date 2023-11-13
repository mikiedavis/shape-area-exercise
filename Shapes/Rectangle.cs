﻿using System;
namespace shape_area.Shapes
{
	public class Rectangle
	{
        private double Height { get; set; }
        private double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return Height * Width;
        }
    }
}

