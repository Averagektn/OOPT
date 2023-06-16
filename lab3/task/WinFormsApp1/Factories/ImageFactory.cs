using L2_1.Figures;
using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace L2_1.Factories
{
    /// <summary>
    /// Factory class for creating instances of MyCoolImage class.
    /// </summary>
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
