namespace WinFormsApp1.Figures
{
    /// <summary>
    /// A class representing an arc.
    /// </summary>
    public class Arc : Rect
    {
        readonly int SweepAngle, StartAngle;
        int Width 
        { 
            get { return Math.Abs(p2.X - p1.X); } 
        }

        int Height
        {
            get { return Math.Abs(p2.Y - p1.Y); }
        }

        /// <summary>
        /// Constructor for the arc class that takes two points, a start angle, and a sweep angle.
        /// </summary>
        /// <param name="p1">The first point of the arc.</param>
        /// <param name="p2">The second point of the arc.</param>
        /// <param name="startAngle">The starting angle of the arc.</param>
        /// <param name="sweepAngle">The sweep angle of the arc.</param>
        public Arc(Point p1, Point p2, int startAngle, int sweepAngle) : base(p1, p2)
        {
            if (p1.X > p2.X)
            {
                this.p1.X = p2.X;
                this.p2.X = p1.X;
            }
            if (p1.Y > p2.Y)
            {
                this.p1.Y = p2.Y;
                this.p2.Y = p1.Y;
            }
            StartAngle = startAngle;
            SweepAngle = sweepAngle;
        }

        /// <summary>
        /// Overrides the abstract method in the base class to draw the arc.
        /// </summary>
        /// <param name="graphics">The graphics object to draw on.</param>
        public override void Draw(Graphics graphics)
        {
            if (p1.X == p2.X || p1.Y == p2.Y)
                graphics.DrawLine(pen, p1, p2);
            else
                graphics.DrawArc(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y), StartAngle, SweepAngle);
        }
    }
}
