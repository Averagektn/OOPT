using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// Factory class for creating Ellipse figures.
    /// </summary>
    public class EllipseFactory : FigureFactory
    {
        /// <summary>
        /// Initializes a new instance of the EllipseFactory class with the specified position and size.
        /// </summary>
        /// <param name="p">The position of the top-left corner of the Ellipse.</param>
        /// <param name="width">The width of the Ellipse.</param>
        /// <param name="height">The height of the Ellipse.</param>
        public EllipseFactory(Point p, int width, int height)
        {
            p1 = p;
            p2.X = p1.X + width;
            p2.Y = p1.Y + height;
        }

        /// <summary>
        /// Creates a new Ellipse figure.
        /// </summary>
        /// <returns>A new Ellipse figure.</returns>
        public override Figure Create()
        {
            return new Ellipse(p1, p2);
        }
    }
}
