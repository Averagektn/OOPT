namespace L2_1.Patterns.Generating.Figures
{
    /// <summary>
    /// Represents a rectangle, which is a type of figure that is defined by its top-left corner point, width, and height.
    /// </summary>
    [Serializable]
    public class Rect : Line
    {
        /// <summary>
        /// Gets the brush used to fill the rectangle.
        /// </summary>
        protected Brush Brush => new SolidBrush(Pen.Color);
        /// <summary>
        /// Initializes a new instance of the Rect class with default values.
        /// </summary>
        public Rect() : base() { }

        /// <summary>
        /// Initializes a new instance of the Rect class with the specified top-left corner point, width, and height.
        /// </summary>
        /// <param name="p1">The top-left corner point of the rectangle.</param>
        /// <param name="w">The width of the rectangle.</param>
        /// <param name="h">The height of the rectangle.</param>
        public Rect(Point p1, int w, int h) : base()
        {
            this.p1 = p1;
            p2.X = p1.X + w;
            p2.Y = p1.Y + h;
        }

        /// <summary>
        /// Initializes a new instance of the Rect class with the specified points.
        /// </summary>
        /// <param name="p1">The first point of the rectangle.</param>
        /// <param name="p2">The second point of the rectangle.</param>
        public Rect(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Determines whether the specified point is contained within the rectangle.
        /// </summary>
        /// <param name="point">The point to check.</param>
        /// <returns>true if the point is contained within the rectangle; otherwise, false.</returns>
        public override bool Contains(Point point)
        {
            if (point.X >= p1.X && point.X <= p2.X && point.Y >= p1.Y && point.Y <= p2.Y)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Draws the rectangle on the specified graphics object.
        /// </summary>
        /// <param name="graphics">The graphics object on which to draw the rectangle.</param>
        public override void Draw(Graphics graphics)
        {
            Pen.Color = Color;
            graphics.DrawRectangle(Pen, p1.X, p1.Y, Width, Height);
            graphics.FillRectangle(Brush, p1.X, p1.Y, Width, Height);
        }
    }
}
