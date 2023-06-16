using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// A factory class for creating Arc objects.
    /// </summary>
    public class ArcFactory : FigureFactory
    {
        readonly int _startAngle, _sweepAngle;

        /// <summary>
        /// Initializes a new instance of the ArcFactory class with the specified parameters.
        /// </summary>
        /// <param name="p1">The starting point of the arc.</param>
        /// <param name="p2">The ending point of the arc.</param>
        /// <param name="startAngle">The angle at which the arc begins, measured in degrees clockwise from the positive x-axis.</param>
        /// <param name="sweepAngle">The angle through which the arc extends, measured in degrees clockwise.</param>
        public ArcFactory(Point p1, Point p2, int startAngle, int sweepAngle)
        {
            this.p1 = p1;
            this.p2 = p2;
            _startAngle = startAngle;
            _sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Creates a new instance of the Arc class using the parameters specified in the constructor.
        /// </summary>
        /// <returns>A new instance of the Arc class.</returns>
        public override Figure Create()
        {
            return new Arc(p1, p2, _startAngle, _sweepAngle);
        }
    }
}
