using WinFormsApp1.Figures;

namespace WinFormsApp1.Factories
{
    /// <summary>
    /// An abstract class for creating Figure objects.
    /// </summary>
    public abstract class FigureFactory
    {
        protected Point p1, p2;

        /// <summary>
        /// Creates a new Figure object.
        /// </summary>
        /// <returns>The newly created Figure object.</returns>
        abstract public Figure Create();
    }
}
