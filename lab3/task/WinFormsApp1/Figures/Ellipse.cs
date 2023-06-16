namespace WinFormsApp1.Figures
{
    /// <summary>
    /// Represents an ellipse shape.
    /// </summary>
    [Serializable]
    public class Ellipse : Rect
    {
        /// <summary>
        /// Initializes a new instance of the Ellipse class with default values.
        /// </summary>
        public Ellipse() : base() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class with the specified points.
        /// </summary>
        /// <param name="p1">The first point.</param>
        /// <param name="p2">The second point.</param>
        public Ellipse(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class with the specified point and dimensions.
        /// </summary>
        /// <param name="p1">The point at the top-left corner of the ellipse's bounding rectangle.</param>
        /// <param name="x">The width of the ellipse's bounding rectangle.</param>
        /// <param name="y">The height of the ellipse's bounding rectangle.</param>
        public Ellipse(Point p1, int x, int y) : base(p1, x, y) { }

        /// <summary>
        /// Determines whether the specified point is located inside this <see cref="Ellipse"/> object.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <returns>true if point is located inside this <see cref="Ellipse"/> object; otherwise, false.</returns>
        public override bool Contains(Point point)
        {
            double center_x = (p1.X + p2.X) / 2.0;
            double center_y = (p1.Y + p2.Y) / 2.0;

            double a = (p2.X - p1.X) / 2.0;
            double b = (p2.Y - p1.Y) / 2.0;

            double distance = Math.Sqrt(Math.Pow((point.X - center_x) / a, 2) + Math.Pow((point.Y - center_y) / b, 2));

            return distance <= 1;
        }

        /// <summary>
        /// Draws the <see cref="Ellipse"/> object on the specified <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object to draw on.</param>
        public override void Draw(Graphics graphics)
        {
            Pen.Color = Color;
            graphics.DrawEllipse(Pen, p1.X, p1.Y, Width, Height);
            graphics.FillEllipse(Brush, p1.X, p1.Y, Width, Height);
        }
    }
}