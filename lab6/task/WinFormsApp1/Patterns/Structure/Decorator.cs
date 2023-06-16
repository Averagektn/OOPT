using L2_1.Patterns.Generating.Figures;

namespace L2_1.Patterns.Structure
{
    internal abstract class Decorator
    {
        protected Figure figure;
        public Decorator(Figure figure)
        {
            this.figure = figure;
        }
    }
}
