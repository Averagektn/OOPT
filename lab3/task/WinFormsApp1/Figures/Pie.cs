using WinFormsApp1.Figures;

namespace L2_1.Figures
{
    /// <summary>
    /// Represents a pie figure, which is a closed arc that is filled with a color.
    /// </summary>
    [Serializable]
    public class Pie : Arc
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pie"/> class.
        /// </summary>
        public Pie() : base() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pie"/> class with the specified start and end points, start angle, and sweep angle.
        /// </summary>
        /// <param name="p1">The start point of the pie.</param>
        /// <param name="p2">The end point of the pie.</param>
        /// <param name="startAngle">The angle between the x-axis and the start point of the pie.</param>
        /// <param name="sweepAngle">The angle between the start point and the endpoint of the pie.</param>
        public Pie(Point p1, Point p2, int startAngle, int sweepAngle) : base(p1, p2, startAngle, sweepAngle) { }

        /// <summary>
        /// Draws the pie on the specified <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object on which to draw the pie.</param>
        public override void Draw(Graphics graphics)
        {
            Pen.Color = Color;
            graphics.DrawPie(Pen, p1.X, p1.Y, Width, Height, startAngle, sweepAngle);
            graphics.FillPie(Brush, p1.X, p1.Y, Width, Height, startAngle, sweepAngle);
        }
    }
}