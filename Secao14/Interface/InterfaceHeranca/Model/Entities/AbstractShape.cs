using InterfaceHeranca.Model.Enums;

namespace InterfaceHeranca.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
