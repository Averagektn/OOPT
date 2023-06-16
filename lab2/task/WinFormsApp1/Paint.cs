using WinFormsApp1.Figures;

namespace WinFormsApp1
{
    /// <summary>
    /// Represents a form for painting graphics.
    /// </summary>
    public partial class PaintForm : Form
    {
        /// <summary>
        /// The graphics object used for drawing on the form.
        /// </summary>
        public Graphics graphics;

        private readonly Main main;
        private int curr = 0;

        /// <summary>
        /// Initializes a new instance of the PaintForm class.
        /// </summary>
        /// <param name="main">The Main form that owns this PaintForm.</param>
        public PaintForm(Main main)
        {
            InitializeComponent();
            graphics = CreateGraphics();
            this.main = main;
        }

        /// <summary>
        /// Handles the FormClosing event of the PaintForm.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">A FormClosingEventArgs that contains the event data.</param>
        public void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            curr = 0;
            e.Cancel = true;
        }

        /// <summary>
        /// Handles the Paint event of the PaintForm.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">A PaintEventArgs that contains the event data.</param>
        public void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            while (curr < Figure.Length)
            {
                main.figures[curr++].Draw(e.Graphics);
            }
        }
    }
}
