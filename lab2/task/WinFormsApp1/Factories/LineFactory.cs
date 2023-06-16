using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// A factory class that creates Line objects.
    /// </summary>
    public class LineFactory : FigureFactory
    {
        /// <summary>
        /// Initializes a new instance of the LineFactory class with the specified start and end points.
        /// </summary>
        /// <param name="p1">The start point of the line.</param>
        /// <param name="p2">The end point of the line.</param>
        public LineFactory(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        /// <summary>
        /// Creates a new Line object using the start and end points specified in the constructor.
        /// </summary>
        /// <returns>A new Line object.</returns>
        public override Figure Create()
        {
            return new Line(p1, p2);
        }
    }
}
