using L2_1.Factories;
using System.Drawing;
using WinFormsApp1.Figures;

namespace Pie
{
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

    public class PieFactory : ArcFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PieFactory"/> class with default values.
        /// </summary>
        public PieFactory() : this(0, 0, 0, 0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieFactory"/> class with specified coordinates and angles.
        /// </summary>
        /// <param name="x1">The x-coordinate of the starting point of the arc.</param>
        /// <param name="y1">The y-coordinate of the starting point of the arc.</param>
        /// <param name="x2">The x-coordinate of the ending point of the arc.</param>
        /// <param name="y2">The y-coordinate of the ending point of the arc.</param>
        /// <param name="startAngle">The starting angle of the pie in degrees.</param>
        /// <param name="sweepAngle">The sweep angle of the pie in degrees.</param>
        public PieFactory(int x1, int y1, int x2, int y2, int startAngle, int sweepAngle) : base(x1, y1, x2, y2, startAngle, sweepAngle) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieFactory"/> class with specified coordinates and angles.
        /// </summary>
        /// <param name="p">The starting point of the arc.</param>
        /// <param name="width">The width of the ellipse that defines the arc.</param>
        /// <param name="height">The height of the ellipse that defines the arc.</param>
        /// <param name="startAngle">The starting angle of the pie in degrees.</param>
        /// <param name="sweepAngle">The sweep angle of the pie in degrees.</param>
        public PieFactory(Point p, int width, int height, int startAngle, int sweepAngle) : base(p, width, height, startAngle, sweepAngle) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PieFactory"/> class with specified coordinates and angles.
        /// </summary>
        /// <param name="p1">The starting point of the arc.</param>
        /// <param name="p2">The ending point of the arc.</param>
        /// <param name="startAngle">The starting angle of the pie in degrees.</param>
        /// <param name="sweepAngle">The sweep angle of the pie in degrees.</param>
        public PieFactory(Point p1, Point p2, int startAngle, int sweepAngle) : base(p1, p2, startAngle, sweepAngle) { }

        /// <summary>
        /// Creates a new Pie object.
        /// </summary>
        /// <returns>A new Pie object.</returns>
        public override Figure Create()
        {
            return new Pie(p1, p2, startAngle, sweepAngle);
        }
    }
}