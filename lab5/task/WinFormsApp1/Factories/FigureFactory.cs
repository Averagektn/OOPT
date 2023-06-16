using WinFormsApp1.Figures;

namespace WinFormsApp1.Factories
{
    /// <summary>
    /// The abstract base class for all figure factories.
    /// </summary>
    public abstract class FigureFactory
    {
        protected Point p1, p2;
        /// <summary>
        /// Initializes a new instance of the FigureFactory class with default values.
        /// </summary>
        public FigureFactory() : this(0, 0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the FigureFactory class with the specified starting and ending points.
        /// </summary>
        /// <param name="x1">The x-coordinate of the starting point.</param>
        /// <param name="y1">The y-coordinate of the starting point.</param>
        /// <param name="x2">The x-coordinate of the ending point.</param>
        /// <param name="y2">The y-coordinate of the ending point.</param>
        public FigureFactory(int x1, int y1, int x2, int y2)
        {
            p1.X = x1;
            p1.Y = y1;
            p2.X = x2;
            p2.Y = y2;
        }

        /// <summary>
        /// Initializes a new instance of the FigureFactory class with the specified starting and ending points.
        /// </summary>
        /// <param name="p1">The starting point.</param>
        /// <param name="p2">The ending point.</param>
        public FigureFactory(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        /// <summary>
        /// Creates a new Figure object.
        /// </summary>
        /// <returns>A new Figure object.</returns>
        abstract public Figure Create();
    }
}