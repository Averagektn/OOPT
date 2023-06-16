namespace WinFormsApp1.Figures
{
    /// <summary>
    /// Abstract class representing a geometric figure.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// The length of the list of figures.
        /// </summary>
        public static int Length { get; set; } = -1;

        static readonly List<Figure> lns = new();
        protected Point p1, p2;
        protected Pen pen;
        const int _penWidth = 3;

        /// <summary>
        /// Abstract method for drawing the figure.
        /// </summary>
        /// <param name="graphics">The graphics object to draw on.</param>
        abstract public void Draw(Graphics graphics);

        /// <summary>
        /// Constructor for the figure class.
        /// </summary>
        public Figure()
        {
            pen = new(Color.FromArgb(new Random().Next(int.MaxValue)))
            {
                Width = _penWidth
            };
            Length++;
        }

        /// <summary>
        /// Indexer for the list of figures.
        /// </summary>
        /// <param name="index">The index of the figure to get or set.</param>
        /// <returns>The figure at the specified index.</returns>
        public Figure this[int index]
        {
            get => lns[index];
            set => lns[index] = value;
        }

        /// <summary>
        /// Adds a figure to the list of figures.
        /// </summary>
        /// <param name="val">The figure to add.</param>
        public static void Add(Figure val)
        {
            lns.Add(val);
        }

        /// <summary>
        /// Returns the count of the figures in the list.
        /// </summary>
        /// <returns>A string with the total count of figures.</returns>
        public static string Count()
        {
            return $"Total figures: {Length}";
        }
    }
}
