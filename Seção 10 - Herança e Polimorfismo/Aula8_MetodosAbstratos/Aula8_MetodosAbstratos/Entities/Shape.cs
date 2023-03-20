using Aula8_MetodosAbstratos.Entities.Enums;

namespace Aula8_MetodosAbstratos.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
