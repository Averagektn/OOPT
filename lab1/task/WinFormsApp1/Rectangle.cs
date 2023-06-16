using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Class of rectangles.
    /// </summary>
    /// <remark>
    /// Contains virual method <see cref="Draw(Graphics)"/>.
    /// Inherited from <see cref="Line"/>.
    /// </remark>
    public class Rectangle : Line
    {
        /// <value>
        /// <c>brush</c> is used to fill figures.
        /// </value>
        protected Brush brush;

        /// <param name="p1">Left top point.</param>
        /// <param name="w">Width.</param>
        /// <param name="h">Height.</param>
        public Rectangle(Point p1, int w, int h) : base()
        {
            brush = new SolidBrush(pen.Color);
            this.p1 = p1;
            p2.X = p1.X + w;
            p2.Y = p1.Y + h;
        }
        
        /// <param name="p1">Left top point.</param>
        /// <param name="p2">Right bottom point.</param>
        public Rectangle(Point p1, Point p2) : base(p1, p2)
        {
            brush = new SolidBrush(pen.Color);
        }

        /// <summary>
        /// Draws figure with filling.
        /// </summary>
        /// <param name="graphics"><see cref="Graphics"></param>
        public override void Draw(Graphics graphics)
        {
            float w = Math.Abs(p2.X - p1.X);
            float h = Math.Abs(p2.Y - p1.Y);
            graphics.DrawRectangle(pen, p1.X, p1.Y, w, h);
            graphics.FillRectangle(brush, p1.X, p1.Y, w, h);
        }
    }
}
