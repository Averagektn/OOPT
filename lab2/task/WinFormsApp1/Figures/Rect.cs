namespace WinFormsApp1.Figures
{
    /// <summary>
    /// A class representing a rectangle.
    /// </summary>
    public class Rect : Line
    {
        protected Brush brush;

        /// <summary>
        /// Constructor for the rectangle class that takes a point, width, and height.
        /// </summary>
        /// <param name="p1">The upper-left corner of the rectangle.</param>
        /// <param name="w">The width of the rectangle.</param>
        /// <param name="h">The height of the rectangle.</param>
        public Rect(Point p1, int w, int h) : base()
        {
            brush = new SolidBrush(pen.Color);
            this.p1 = p1;
            p2.X = p1.X + w;
            p2.Y = p1.Y + h;
        }

        /// <summary>
        /// Constructor for the rectangle class that takes two points.
        /// </summary>
        /// <param name="p1">The first point of the rectangle.</param>
        /// <param name="p2">The second point of the rectangle.</param>
        public Rect(Point p1, Point p2) : base(p1, p2)
        {
            brush = new SolidBrush(pen.Color);
        }

        /// <summary>
        /// Overrides the abstract method in the base class to draw the rectangle.
        /// </summary>
        /// <param name="graphics">The graphics object to draw on.</param>
        public override void Draw(Graphics graphics)
        {
            float w = Math.Abs(p2.X - p1.X);
            float h = Math.Abs(p2.Y - p1.Y);
            graphics.DrawRectangle(pen, p1.X, p1.Y, w, h);
            graphics.FillRectangle(brush, p1.X, p1.Y, w, h);
        }
    }
}
