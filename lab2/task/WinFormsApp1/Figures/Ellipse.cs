namespace WinFormsApp1.Figures
{
    /// <summary>
    /// Represents an ellipse figure, which is a closed curve in a plane that is symmetric around two perpendicular axes and has a circular shape.
    /// </summary>
    public class Ellipse : Rect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class with the specified points.
        /// </summary>
        /// <param name="p1">The starting point of the ellipse.</param>
        /// <param name="p2">The ending point of the ellipse.</param>
        public Ellipse(Point p1, Point p2) : base(p1, p2) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse"/> class with the specified point and dimensions.
        /// </summary>
        /// <param name="p1">The starting point of the ellipse.</param>
        /// <param name="x">The horizontal dimension of the ellipse.</param>
        /// <param name="y">The vertical dimension of the ellipse.</param>
        public Ellipse(Point p1, int x, int y) : base(p1, x, y) { }

        /// <summary>
        /// Draws the ellipse on the specified <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object on which to draw the ellipse.</param>
        public override void Draw(Graphics graphics)
        {
            float w = Math.Abs(p2.X - p1.X);
            float h = Math.Abs(p2.Y - p1.Y);
            graphics.DrawEllipse(pen, p1.X, p1.Y, w, h);
            graphics.FillEllipse(brush, p1.X, p1.Y, w, h);
        }
    }
}
