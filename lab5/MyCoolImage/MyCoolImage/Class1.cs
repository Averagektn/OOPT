using System.Drawing;
using WinFormsApp1.Figures;
using WinFormsApp1.Factories;

namespace MyImage
{
    public class Test
    {
        public int a;
    }
    public class MyCoolImage : Figure
    {
        /// <summary>
        /// Gets or sets the file name of the image.
        /// </summary>
        public string FileName { get; set; } = "";
        /// <summary>
        /// Gets the image object from the file.
        /// </summary>
        protected Image Image => Image.FromFile(FileName);

        /// <summary>
        /// Initializes a new instance of the <see cref="MyCoolImage"/> class.
        /// </summary>
        public MyCoolImage() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyCoolImage"/> class with the specified file name, start point, and end point.
        /// </summary>
        /// <param name="fileName">The file name of the image.</param>
        /// <param name="p1">The start point of the image.</param>
        /// <param name="p2">The end point of the image.</param>
        public MyCoolImage(string fileName, Point p1, Point p2) : base(p1, p2)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Determines whether the current <see cref="MyCoolImage"/> object is equal to another object of the same type.
        /// </summary>
        /// <typeparam name="T">The type of the object to compare with the current object.</typeparam>
        /// <param name="figure">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        public override bool Equals<T>(T figure)
        {
            if (base.Equals(figure) && FileName == (figure as MyCoolImage)?.FileName)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether the specified point is contained within this <see cref="MyCoolImage"/> object.
        /// </summary>
        /// <param name="point">The point to test.</param>
        /// <returns>true if the point is contained within this object; otherwise, false.</returns>
        public override bool Contains(Point point)
        {
            if (point.X >= p1.X && point.X <= p2.X && point.Y >= p1.Y && point.Y <= p2.Y)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Draws the <see cref="MyCoolImage"/> object on the specified <see cref="Graphics"/> object.
        /// </summary>
        /// <param name="graphics">The <see cref="Graphics"/> object to draw on.</param>
        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image, p1.X, p1.Y, Width, Height);
        }

    }

    public class ImageFactory : FigureFactory
    {
        /// <summary>
        /// Gets or sets the file name of the image.
        /// </summary>
        protected string FileName { get; set; }

        /// <summary>
        /// Initializes a new instance of the ImageFactory class with default values.
        /// </summary>
        public ImageFactory() : this("", 0, 0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the ImageFactory class with specified values.
        /// </summary>
        /// <param name="fileName">The file name of the image.</param>
        /// <param name="x1">The x-coordinate of the first point.</param>
        /// <param name="y1">The y-coordinate of the first point.</param>
        /// <param name="x2">The x-coordinate of the second point.</param>
        /// <param name="y2">The y-coordinate of the second point.</param>
        public ImageFactory(string fileName, int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the ImageFactory class with specified values.
        /// </summary>
        /// <param name="fileName">The file name of the image.</param>
        /// <param name="p1">The first point.</param>
        /// <param name="p2">The second point.</param>
        public ImageFactory(string fileName, Point p1, Point p2) : base(p1, p2)
        {
            FileName = fileName;
        }

        /// <summary>
        /// Creates a new instance of the MyCoolImage class with the specified file name and points.
        /// </summary>
        /// <returns>A new instance of the MyCoolImage class.</returns>
        public override Figure Create()
        {
            return new MyCoolImage(FileName, p1, p2);
        }
    }
}