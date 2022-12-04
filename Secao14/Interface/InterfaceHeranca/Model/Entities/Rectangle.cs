using System;
using System.Globalization;
using InterfaceHeranca.Model.Enums;

namespace InterfaceHeranca.Model.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectangle color: "
                + Color
                + ", width: "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height: "
                + Heigth.ToString("F2", CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
