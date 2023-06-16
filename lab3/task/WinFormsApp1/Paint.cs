namespace WinFormsApp1
{
    public partial class PaintForm : Form
    {
        public Graphics graphics;

        private readonly Main main;

        public PaintForm(Main main)
        {
            InitializeComponent();
            graphics = CreateGraphics();
            this.main = main;
        }

        public void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
        }

        public void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < main?.figures?.Length; i++)
            {
                main.figures[i].Draw(e.Graphics);
            }
        }

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