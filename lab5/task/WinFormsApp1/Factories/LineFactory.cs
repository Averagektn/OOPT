using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// A factory class for creating Line objects.
    /// </summary>
    public class LineFactory : FigureFactory
    {
        /// <summary>
        /// Initializes a new instance of the LineFactory class.
        /// </summary>
        public LineFactory() : base() { }
        /// <summary>
        /// Initializes a new instance of the LineFactory class with the specified x and y coordinates.
        /// </summary>
        /// <param name="x1">The x-coordinate of the starting point of the line.</param>
        /// <param name="y1">The y-coordinate of the starting point of the line.</param>
        /// <param name="x2">The x-coordinate of the ending point of the line.</param>
        /// <param name="y2">The y-coordinate of the ending point of the line.</param>
        public LineFactory(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

        /// <summary>
        /// Initializes a new instance of the LineFactory class with the specified starting and ending points.
        /// </summary>
        /// <param name="p1">The starting point of the line.</param>
        /// <param name="p2">The ending point of the line.</param>
        public LineFactory(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Creates a new Line object using the starting and ending points specified in the factory.
        /// </summary>
        /// <returns>A new Line object.</returns>
        public override Figure Create()
        {
            return new Line(p1, p2);
        }
    }
}