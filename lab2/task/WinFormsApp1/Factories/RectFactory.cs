using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// A factory class for creating instances of the Rect class.
    /// </summary>
    public class RectFactory : FigureFactory
    {
        /// <summary>
        /// Initializes a new RectFactory with the specified parameters.
        /// </summary>
        /// <param name="p">The top-left corner of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public RectFactory(Point p, int width, int height)
        {
            p1 = p;
            p2.X = p1.X + width;
            p2.Y = p1.Y + height;
        }

        /// <summary>
        /// Creates a new instance of the Rect class with the parameters specified in the constructor.
        /// </summary>
        /// <returns>A new instance of the Rect class.</returns>
        public override Figure Create()
        {
            return new Rect(p1, p2);
        }
    }
}
