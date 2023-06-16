namespace WinFormsApp1.Figures
{
    /// <summary>
    /// A class representing a line.
    /// </summary>
    public class Line : Figure
    {
        /// <summary>
        /// Default constructor for the line class.
        /// </summary>
        public Line() : this(0, 0, 0, 0) { }

        /// <summary>
        /// Constructor for the line class that takes coordinates for the start and end points of the line.
        /// </summary>
        /// <param name="x1">The x-coordinate of the start point.</param>
        /// <param name="y1">The y-coordinate of the start point.</param>
        /// <param name="x2">The x-coordinate of the end point.</param>
        /// <param name="y2">The y-coordinate of the end point.</param>
        public Line(int x1, int y1, int x2, int y2)
        {
            p1.X = x1;
            p1.Y = y1;
            p2.X = x2;
            p2.Y = y2;
        }

        /// <summary>
        /// Constructor for the line class that takes start and end points as <c>Point</c> objects.
        /// </summary>
        /// <param name="p1">The start point of the line.</param>
        /// <param name="p2">The end point of the line.</param>
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        /// <summary>
        /// Overrides the abstract method in the base class to draw the line.
        /// </summary>
        /// <param name="graphics">The graphics object to draw on.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, p1, p2);
        }
    }
}
