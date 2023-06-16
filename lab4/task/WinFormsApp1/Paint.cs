namespace WinFormsApp1
{
    /// <summary>
    /// Form used for displaying painted figures.
    /// </summary>
    public partial class PaintForm : Form
    {
        public Graphics graphics;

        private readonly Main main;

        /// <summary>
        /// Initializes a new instance of the PaintForm class.
        /// </summary>
        /// <param name="main">The main form of the application.</param>
        public PaintForm(Main main)
        {
            InitializeComponent();
            graphics = CreateGraphics();
            this.main = main;
        }

        /// <summary>
        /// Event handler for the form's Closing event.
        /// Hides the form and cancels the close event.
        /// </summary>
        public void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        /// <summary>
        /// Event handler for the form's Paint event.
        /// Draws all figures in the main form's figures list.
        /// </summary>
        public void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < main?.figures?.Length; i++)
            {
                main.figures[i].Draw(e.Graphics);
            }
        }

        /// <summary>
        /// Event handler for the form's MouseClick event.
        /// Removes the figure at the clicked location from the main form's figures list and invalidates the form.
        /// </summary>
        private void PaintForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < main?.figures?.Length; i++)
            {
                if (main.figures[i].Contains(e.Location))
                {
                    main.figures.Remove(main.figures[i--]);
                    Invalidate();
                    main.Text = main.figures.Count();
                }
            }
        }

    }
}