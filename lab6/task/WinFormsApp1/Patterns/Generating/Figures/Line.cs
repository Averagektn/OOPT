namespace L2_1.Patterns.Generating.Figures
{
    /// <summary>
    /// Represents a straight line figure.
    /// </summary>
    [Serializable]
    public class Line : Figure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with default coordinates.
        /// </summary>
        public Line() : this(0, 0, 0, 0) { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with the specified coordinates.
        /// </summary>
        /// <param name="x1">The x-coordinate of the start point.</param>
        /// <param name="y1">The y-coordinate of the start point.</param>
        /// <param name="x2">The x-coordinate of the end point.</param>
        /// <param name="y2">The y-coordinate of the end point.</param>
        public Line(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with the specified points.
        /// </summary>
        /// <param name="p1">The start point.</param>
        /// <param name="p2">The end point.</param>
        public Line(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Determines whether the specified point is contained within the line.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <returns><c>true</c> if the point is contained within the line; otherwise, <c>false</c>.</returns>
        public override bool Contains(Point point)
        {
            int dx = Math.Abs(p2.X - p1.X);
            int dy = Math.Abs(p2.Y - p1.Y);
            double expectedY;
            try
            {
                expectedY = p1.Y + dy / dx * (point.X - p1.X);
            }
            catch
            {
                return true;
            }

            return Math.Abs(point.Y - expectedY) < 5;
        }

        /// <summary>
        /// Draws the line using the specified graphics object and pen color.
        /// </summary>
        /// <param name="graphics">The graphics object used to draw the line.</param>
        public override void Draw(Graphics graphics)
        {
            Pen.Color = Color;
            graphics.DrawLine(Pen, p1, p2);
        }
    }
}