using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace WinFormsApp1.Figures
{

    /// <summary>
    /// Represents a geometric figure.
    /// </summary>
    [Serializable]
    public class Figure
    {
        /// <summary>
        /// The list of figures contained in this figure.
        /// </summary>
        [JsonProperty("figures")]
        private readonly List<Figure> figures = new();

        /// <summary>
        /// Gets the number of figures contained in this figure.
        /// </summary>
        public int Length => figures.Count;

        /// <summary>
        /// Gets the width of the figure.
        /// </summary>
        protected float Width => Math.Abs(p1.X - p2.X);

        /// <summary>
        /// Gets the height of the figure.
        /// </summary>
        protected float Height => Math.Abs(p1.Y - p2.Y);

        /// <summary>
        /// The first point of the figure.
        /// </summary>
        public Point p1;

        /// <summary>
        /// The second point of the figure.
        /// </summary>
        public Point p2;

        /// <summary>
        /// The color of the figure.
        /// </summary>
        public Color Color;

        /// <summary>
        /// The pen used to draw the figure.
        /// </summary>
        protected Pen Pen;

        /// <summary>
        /// The width of the pen used to draw the figure.
        /// </summary>
        private const int PEN_WIDTH = 3;

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class with default values.
        /// </summary>
        public Figure() : this(0, 0, 0, 0) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class with the specified points.
        /// </summary>
        /// <param name="x1">The x-coordinate of the first point.</param>
        /// <param name="y1">The y-coordinate of the first point.</param>
        /// <param name="x2">The x-coordinate of the second point.</param>
        /// <param name="y2">The y-coordinate of the second point.</param>
        public Figure(int x1, int y1, int x2, int y2)
        {
            Pen = new(Color.FromArgb(new Random().Next(int.MaxValue)))
            {
                Width = PEN_WIDTH
            };
            Color = Pen.Color;
            p1 = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            p2 = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Figure"/> class with the specified points.
        /// </summary>
        /// <param name="p1">The first point.</param>
        /// <param name="p2">The second point.</param>
        public Figure(Point p1, Point p2)
        {
            Pen = new(Color.FromArgb(new Random().Next(int.MaxValue)))
            {
                Width = PEN_WIDTH
            };
            Color = Pen.Color;
            this.p1 = new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
            this.p2 = new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
        }

        /// <summary>
        /// Gets or sets the figure at the specified index.
        /// </summary>
        /// <param name="index">The index of the figure to get or set.</param>
        /// <returns>The figure</returns>
        public Figure this[int index]
        {
            get => figures[index];
            set => figures[index] = value;
        }
        /// <summary>
        /// Draws the figure on the specified graphics object.
        /// </summary>
        /// <param name="graphics">The graphics object to draw the figure on.</param>
        public virtual void Draw(Graphics graphics)
        {
            Pen = new(Color)
            {
                Width = PEN_WIDTH
            };
        }

        /// <summary>
        /// Determines whether the figure contains the specified point.
        /// </summary>
        /// <param name="point">The point to test for containment.</param>
        /// <returns>True if the figure contains the point; otherwise, false.</returns>
        public virtual bool Contains(Point point)
        {
            return false;
        }

        /// <summary>
        /// Removes the specified figure from the figures list if it exists.
        /// </summary>
        /// <param name="figure">The figure to remove.</param>
        public void Remove(Figure figure)
        {
            if (figures.Contains(figure))
            {
                figures.Remove(figure);
            }
        }

        public void RemoveAll(Predicate<Figure> match)
        {
            figures.RemoveAll(match);
        }

        /// <summary>
        /// Determines whether this figure is equal to the specified figure.
        /// </summary>
        /// <typeparam name="T">The type of figure to compare to.</typeparam>
        /// <param name="figure">The figure to compare to.</param>
        /// <returns>True if the figures are equal; otherwise, false.</returns>
        public virtual bool Equals<T>(T figure) where T : Figure
        {
            if (GetType() == figure?.GetType() && figure.p1 == p1 && figure.p2 == p2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds the specified figure to the figures list if it does not already exist, and returns its index.
        /// </summary>
        /// <param name="val">The figure to add.</param>
        /// <returns>The index of the added figure.</returns>
        public int AddUnique(Figure? val)
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (val != null && val.Equals(figures[i]))
                {
                    figures[i].Pen = new(Color.FromArgb(new Random().Next(int.MaxValue)))
                    {
                        Width = PEN_WIDTH
                    };

                    figures[i].Color = figures[i].Pen.Color;
                    return i;
                }
            }
            if (val != null)
            {
                figures.Add(val);
            }
            return Length - 1;
        }

        /// <summary>
        /// Returns a string representation of the total number of figures in the list.
        /// </summary>
        /// <returns>A string representation of the total number of figures.</returns>
        public string Count()
        {
            return $"Total figures: {Length}";
        }

        /// <summary>
        /// Serializes the figures list to a JSON file with the specified filename.
        /// </summary>
        /// <param name="fileName">The filename to use for the JSON file.</param>
        /// <param name="figures">The figures list to serialize.</param>
        public static void SerializeJSON(string fileName, Figure? figures)
        {
            using var sw = new StreamWriter(fileName);
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(figures, settings);
            sw.Write(json);
        }

        /// <summary>
        /// Deserializes the figures list from a JSON file with the specified filename.
        /// </summary>
        /// <param name="fileName">The name of the file to read from.</param>
        /// <returns>A Figure object representing the deserialized figures list.</returns>
        public static Figure? DeserializeJSON(string fileName)
        {
            using var sr = new StreamReader(fileName);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = sr.ReadToEnd();
            Figure? res;
            try
            {
                res = JsonConvert.DeserializeObject<Figure>(json, settings);
            }
            catch
            {
                res = null;
            }
            return res;
        }
    }
}