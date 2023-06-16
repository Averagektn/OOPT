using L2_1.Patterns.Generating.Figures;

namespace L2_1.Patterns.Generating.Factories
{
    /// <summary>
    /// A factory class for creating instances of the Rect class.
    /// </summary>
    public class RectFactory : LineFactory
    {
        /// <summary>
        /// Initializes a new instance of the RectFactory class with default values.
        /// </summary>
        public RectFactory() : base() { }
        /// <summary>
        /// Initializes a new instance of the RectFactory class with the specified x and y coordinates for the starting and ending points of the rectangle.
        /// </summary>
        /// <param name="x1">The x coordinate of the starting point of the rectangle.</param>
        /// <param name="y1">The y coordinate of the starting point of the rectangle.</param>
        /// <param name="x2">The x coordinate of the ending point of the rectangle.</param>
        /// <param name="y2">The y coordinate of the ending point of the rectangle.</param>
        public RectFactory(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

        /// <summary>
        /// Initializes a new instance of the RectFactory class with the specified starting and ending points of the rectangle.
        /// </summary>
        /// <param name="p1">The starting point of the rectangle.</param>
        /// <param name="p2">The ending point of the rectangle.</param>
        public RectFactory(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Initializes a new instance of the RectFactory class with the specified starting point and dimensions of the rectangle.
        /// </summary>
        /// <param name="p">The starting point of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public RectFactory(Point p, int width, int height)
        {
            p1 = p;
            p2.X = p1.X + width;
            p2.Y = p1.Y + height;
        }

        /// <summary>
        /// Creates a new instance of the Rect class with the specified starting and ending points.
        /// </summary>
        /// <returns>A new instance of the Rect class.</returns>
        public override Figure Create()
        {
            return new Rect(p1, p2);
        }
    }
}
