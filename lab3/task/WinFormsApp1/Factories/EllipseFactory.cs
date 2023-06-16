using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// Factory class for creating instances of the Ellipse class.
    /// </summary>
    public class EllipseFactory : RectFactory
    {
        /// <summary>
        /// Initializes a new instance of the EllipseFactory class with default values.
        /// </summary>
        public EllipseFactory() : base() { }
        /// <summary>
        /// Initializes a new instance of the EllipseFactory class with the specified coordinate values.
        /// </summary>
        /// <param name="x1">The x-coordinate of the first point.</param>
        /// <param name="y1">The y-coordinate of the first point.</param>
        /// <param name="x2">The x-coordinate of the second point.</param>
        /// <param name="y2">The y-coordinate of the second point.</param>
        public EllipseFactory(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

        /// <summary>
        /// Initializes a new instance of the EllipseFactory class with the specified points.
        /// </summary>
        /// <param name="p1">The first point.</param>
        /// <param name="p2">The second point.</param>
        public EllipseFactory(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Initializes a new instance of the EllipseFactory class with the specified point, width, and height.
        /// </summary>
        /// <param name="p">The point at which the ellipse will be drawn.</param>
        /// <param name="width">The width of the ellipse.</param>
        /// <param name="height">The height of the ellipse.</param>
        public EllipseFactory(Point p, int width, int height) : base(p, width, height) { }

        /// <summary>
        /// Creates a new instance of the Ellipse class using the specified points.
        /// </summary>
        /// <returns>A new instance of the Ellipse class.</returns>
        public override Figure Create()
        {
            return new Ellipse(p1, p2);
        }
    }
}