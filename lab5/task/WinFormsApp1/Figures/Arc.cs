using System.Drawing.Drawing2D;

namespace WinFormsApp1.Figures
{
    /// <summary>
    /// Represents an arc figure.
    /// </summary>
    [Serializable]
    public class Arc : Rect
    {
        /// <summary>
        /// The angle between the start point and the endpoint of the arc.
        /// </summary>
        public int sweepAngle;
        /// <summary>
        /// The angle between the x-axis and the start point of the arc.
        /// </summary>
        public int startAngle;

        /// <summary>
        /// Initializes a new instance of the <see cref="Arc"/> class.
        /// </summary>
        public Arc() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Arc"/> class with the specified start and end points, start angle, and sweep angle.
        /// </summary>
        /// <param name="p1">The start point of the arc.</param>
        /// <param name="p2">The end point of the arc.</param>
        /// <param name="startAngle">The angle between the x-axis and the start point of the arc.</param>
        /// <param name="sweepAngle">The angle between the start point and the endpoint of the arc.</param>
        public Arc(Point p1, Point p2, int startAngle, int sweepAngle) : base(p1, p2)
        {
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Determines whether the specified point is contained within the arc figure.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <returns>true if the specified point is contained within the arc figure; otherwise, false.</returns>
        public override bool Contains(Point point)
        {
            var ellipseBounds = new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );

            var path = new GraphicsPath();
            path.AddPie(ellipseBounds, startAngle, sweepAngle);

            return path.IsVisible(point);
        }

        /// <summary>
        /// Draws the arc figure on the specified graphics context.
        /// </summary>
        /// <param name="graphics">The graphics context on which to draw the arc figure.</param>
        public override void Draw(Graphics graphics)
        {
            Pen.Color = Color;
            if (p1.X == p2.X || p1.Y == p2.Y)
                graphics.DrawLine(Pen, p1, p2);
            else
                graphics.DrawArc(Pen, p1.X, p1.Y, Width, Height, startAngle, sweepAngle);
        }

        /// <summary>
        /// Determines whether the specified figure is equal to the current arc figure.
        /// </summary>
        /// <typeparam name="T">The type of the figure to compare.</typeparam>
        /// <param name="figure">The figure to compare.</param>
        /// <returns>true if the specified figure is equal to the current arc figure; otherwise, false.</returns>
        public override bool Equals<T>(T figure)
        {
            if (base.Equals(figure) && sweepAngle == (figure as Arc)?.sweepAngle && startAngle == (figure as Arc)?.startAngle)
            {
                return true;
            }
            return false;
        }
    }
}