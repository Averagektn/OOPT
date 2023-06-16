using L2_1.Patterns.Generating.Figures;

namespace L2_1.Patterns.Generating.Factories
{
    /// <summary>
    /// A factory class for creating <see cref="Arc"/> objects.
    /// </summary>
    public class ArcFactory : EllipseFactory
    {
        protected int startAngle, sweepAngle;
        /// <summary>
        /// Initializes a new instance of the <see cref="ArcFactory"/> class.
        /// </summary>
        public ArcFactory() : this(0, 0, 0, 0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArcFactory"/> class with the specified coordinates and angles.
        /// </summary>
        /// <param name="x1">The x-coordinate of the first point.</param>
        /// <param name="y1">The y-coordinate of the first point.</param>
        /// <param name="x2">The x-coordinate of the second point.</param>
        /// <param name="y2">The y-coordinate of the second point.</param>
        /// <param name="startAngle">The starting angle of the arc.</param>
        /// <param name="sweepAngle">The sweep angle of the arc.</param>
        public ArcFactory(int x1, int y1, int x2, int y2, int startAngle, int sweepAngle) : base(x1, y1, x2, y2)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArcFactory"/> class with the specified location, size, and angles.
        /// </summary>
        /// <param name="p">A <see cref="Point"/> that represents the upper-left corner of the bounding rectangle for the arc.</param>
        /// <param name="width">The width of the bounding rectangle for the arc.</param>
        /// <param name="height">The height of the bounding rectangle for the arc.</param>
        /// <param name="startAngle">The starting angle of the arc.</param>
        /// <param name="sweepAngle">The sweep angle of the arc.</param>
        public ArcFactory(Point p, int width, int height, int startAngle, int sweepAngle) : base(p, width, height)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArcFactory"/> class with the specified coordinates, size, and angles.
        /// </summary>
        /// <param name="p1">A <see cref="Point"/> that represents the first point.</param>
        /// <param name="p2">A <see cref="Point"/> that represents the second point.</param>
        /// <param name="startAngle">The starting angle of the arc.</param>
        /// <param name="sweepAngle">The sweep angle of the arc.</param>
        public ArcFactory(Point p1, Point p2, int startAngle, int sweepAngle)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Arc"/> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="Arc"/> class.</returns>
        public override Figure Create()
        {
            return new Arc(p1, p2, startAngle, sweepAngle);
        }
    }
}
