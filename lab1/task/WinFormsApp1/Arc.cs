using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Class of arcs.
    /// </summary>
    /// <remark>
    /// Contains virual method <see cref="Draw(Graphics)"/>.
    /// Inherited from <see cref="Rectangle"/>.
    /// </remark>
    public class Arc : Rectangle
    {
        /// <variable>
        /// <c>startAngle</c>: Angle in degrees measured clockwise from the x-axis to the starting point of the arc.
        /// <c>sweepAngle</c>: Angle in degrees measured clockwise from the startAngle parameter to ending point of the arc.
        /// </variable>
        int _startAngle, _sweepAngle;

        /// <param name="p1">Start point</param>
        /// <param name="p2">End point</param>
        /// <param name="startAngle">Angle in degrees measured clockwise from the x-axis to the starting point of the arc.</param>
        /// <param name="sweepAngle">Angle in degrees measured clockwise from the startAngle parameter to ending point of the arc.</param>
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
            _startAngle = startAngle;
            _sweepAngle = sweepAngle;
        }

        /// <summary>
        /// Draws an arc.
        /// Inherited from: <see cref="Rectangle.Draw(Graphics)"/>
        /// </summary>
        /// <param name="graphics"><see cref="Graphics"/></param>
        public override void Draw(Graphics graphics)
        {
            if (p1.X == p2.X || p1.Y == p2.Y)
            {
                graphics.DrawLine(pen, p1, p2);
            }
            else
            {
                if (p1.X > p2.X)
                {
                    
                }
                graphics.DrawArc(pen, p1.X, p1.Y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y), _startAngle, _sweepAngle);
            }
        }
    }
}
