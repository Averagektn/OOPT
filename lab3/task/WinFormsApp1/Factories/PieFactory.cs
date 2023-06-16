using L2_1.Figures;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// A factory class for creating Pie figures.
    /// </summary>
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
