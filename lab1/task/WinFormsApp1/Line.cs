using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// Base class of figures.
    /// Draws figures and counts their total number.
    /// </summary>
    /// <remarks>
    /// Contains virual method <term>Draw</term>.
    /// </remarks>
    public class Line
    {
        /// <value>
        /// The <c>p1, p2</c> fields stand for starting and ending point of the line.
        /// The <c> pen </c> field stands for the Pen, which will be used to draw.
        /// The <c> counter </c> field counts the number of drawn figures.
        /// <remark> figures are objects of Line class and its children.</remark> 
        /// </value>
        protected Point p1, p2;
        protected Pen pen;
        static int s_counter = 0;
        const int _penWidth = 3;

        /// <summary>
        /// Constructor for no arguments.
        /// </summary>
        public Line() : this(0, 0, 0, 0)
        {
            s_counter++;
        }

        /// <summary>
        /// Constructor for 4 coordiantes.
        /// </summary>
        /// <param name="x1">First coordiante X <remarks>For <c>p1.X</c></remarks>.</param>
        /// <param name="y1">First coordinate Y <remarks>For <c>p1.Y</c></remarks>.</param>
        /// <param name="x2">Second coordinate X <remarks>For <c>p2.X</c></remarks>.</param>
        /// <param name="y2">Second coordinate Y <remarks>For <c>p2.Y</c></remarks>.</param>
        public Line(int x1, int y1, int x2, int y2)
        {
            pen = new Pen(Color.FromArgb(new Random().Next(int.MaxValue)));
            pen.Width = _penWidth;
            p1.X = x1;
            p1.Y = y1;
            p2.X = x2;
            p2.Y = y2;
        }

        /// <summary>
        /// Constructor for 2 points.
        /// </summary>
        /// <param name="p1">Start point.</param>
        /// <param name="p2">End point.</param>
        public Line(Point p1, Point p2)
        {
            s_counter++;
            pen = new Pen(Color.FromArgb(new Random().Next(int.MaxValue)));
            pen.Width = 3;
            this.p1 = p1;
            this.p2 = p2;
        }

        /// <summary>
        /// Virtual method for drawing figure
        /// </summary>
        /// <param name="graphics">Variable for drawing <see cref="Graphics"></param>
        public virtual void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, p1, p2);   
        }

        /// <summary>
        /// Counter
        /// </summary>
        /// <returns>String with information about the number of figures</returns>
        public static string Count()
        {
            return $"Total figures: {s_counter}";
        }
    }
}
