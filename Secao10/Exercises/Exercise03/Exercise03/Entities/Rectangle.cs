﻿using Exercise03.Entities.Enums;

namespace Exercise03.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
