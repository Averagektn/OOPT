using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Class of ellipses.
    /// </summary>
    /// <remark>
    /// Contains virual method <see cref="Draw(Graphics)"/>.
    /// Inherited from <see cref="Rectangle"/>.
    /// </remark>
    public class Ellipse : Rectangle
    {
        /// <summary>
        /// Same as <see cref="Rectangle(Point, int, int)"/> constructor.
        /// </summary>
        /// <param name="p1">Left top point.</param>
        /// <param name="x">Width diameter.</param>
        /// <param name="y">Height diameter.</param>
        public Ellipse(Point p1, int x, int y) : base(p1, x, y) { }

        /// <summary>
        /// Draws ellipse with filling.
        /// Inherited from: <see cref="Rectangle.Draw(Graphics)"/>
        /// </summary>
        /// <param name="graphics"><see cref="Graphics"/></param>
        public override void Draw(Graphics graphics)
        {
            float w = Math.Abs(p2.X - p1.X);
            float h = Math.Abs(p2.Y - p1.Y);
            graphics.DrawEllipse(pen, p1.X, p1.Y, w, h);
            graphics.FillEllipse(brush, p1.X, p1.Y, w, h);
        }
    }
}
