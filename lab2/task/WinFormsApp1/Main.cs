using L2_1.Factories;
using WinFormsApp1.Figures;

namespace WinFormsApp1
{
    /// <summary>
    /// The Main form that allows the user to create and draw different geometric shapes.
    /// </summary>
    public partial class Main : Form
    {
        public Line figures = new();

        private readonly PaintForm FormPaint;
        private readonly TextBox[] TextBoxes;
        private readonly Button[] Buttons;

        /// <summary>
        /// Constructor of the Main form.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            FormPaint = new PaintForm(this);
            Text = Figure.Count();
            TextBoxes = new TextBox[] { tbArcX1, tbArcY2, tbArcX2, tbArcY2, tbArcStartAngle, tbArcSweepAngle, 
                tbEllipseX, tbEllipseY, tbEllipseWidth, tbEllipseHeight, tbRectX, tbRectY, tbRectWidth, 
                tbRectHeight, tbLineX1, tbLineY1, tbLineX2, tbLineY2 
            };
            Buttons = new Button[] { btnDrawArc, btnDrawEllipse, btnDrawRect, btnDrawLine };
        }

        /// <summary>
        /// Handles the KeyPress event of the text boxes and only allows digits and backspace to be entered.
        /// </summary>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the DrawLine button and draws a Line on the PaintForm.
        /// </summary>
        private void DrawLine_Click(object sender, EventArgs e)
        {
            FormPaint.Show();
            Point p1 = new(Convert.ToInt32(tbLineX1.Text), Convert.ToInt32(tbLineY1.Text));
            Point p2 = new(Convert.ToInt32(tbLineX2.Text), Convert.ToInt32(tbLineY2.Text));
            LineFactory factory = new(p1, p2);
            Figure.Add(factory.Create());
            figures[Figure.Length - 1].Draw(FormPaint.graphics);
            Text = Figure.Count();
       
        }

        /// <summary>
        /// Handles the Click event of the DrawRect button and draws a Rectangle on the PaintForm.
        /// </summary>
        private void DrawRect_Click(object sender, EventArgs e)
        {
            FormPaint.Show();
            Point p = new(Convert.ToInt32(tbRectX.Text), Convert.ToInt32(tbRectY.Text));
            int width = Convert.ToInt32(tbRectWidth.Text);
            int height = Convert.ToInt32(tbRectHeight.Text);
            RectFactory factory = new(p, width, height);
            Figure.Add(factory.Create());
            figures[Figure.Length - 1].Draw(FormPaint.graphics);
            Text = Figure.Count();
        }

        /// <summary>
        /// Handles the Click event of the DrawEllipse button and draws an Ellipse on the PaintForm.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs associated with the event.</param>
        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            FormPaint.Show();
            Point p = new(Convert.ToInt32(tbEllipseX.Text), Convert.ToInt32(tbEllipseY.Text));
            int width = Convert.ToInt32(tbEllipseWidth.Text);
            int height = Convert.ToInt32(tbEllipseHeight.Text);
            EllipseFactory factory = new(p, width, height);
            Figure.Add(factory.Create());
            figures[Figure.Length - 1].Draw(FormPaint.graphics);
            Text = Figure.Count();
        }

        /// <summary>
        /// Handles the Click event of the DrawArc button and draws an Arc on the PaintForm.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs associated with the event.</param>
        private void DrawArc_Click(object sender, EventArgs e)
        {
            FormPaint.Show();
            Point p1 = new(Convert.ToInt32(tbArcX1.Text), Convert.ToInt32(tbArcY1.Text));
            Point p2 = new(Convert.ToInt32(tbArcX2.Text), Convert.ToInt32(tbArcY2.Text));
            int startAngle = Convert.ToInt32(tbArcStartAngle.Text);
            int sweepAngle = Convert.ToInt32(tbArcSweepAngle.Text);
            ArcFactory factory = new(p1, p2, startAngle, sweepAngle);
            Figure.Add(factory.Create());
            figures[Figure.Length - 1].Draw(FormPaint.graphics);
            Text = Figure.Count();
        }

        /// <summary>
        /// Handles the TextChanged event of the TextBox controls and enables or disables the corresponding button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs associated with the event.</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag), i = 0;
            const int TB_ARCS = 6, TB_DEFAULT = 4, BTN_ARC = 0;
            if (index < TB_ARCS)
            {
                while (i < TB_ARCS && TextBoxes[i].Text.Length > 0)
                    i++;
                if (i == TB_ARCS)
                    Buttons[BTN_ARC].Enabled = true;
                else
                    Buttons[BTN_ARC].Enabled = false;
            }
            else
            {
                int last = ((index - TB_ARCS) / TB_DEFAULT) * TB_DEFAULT + TB_DEFAULT + TB_ARCS;
                int btn = (index - TB_ARCS) / TB_DEFAULT + 1;
                i = last - TB_DEFAULT;
                while (i < last && TextBoxes[i].Text.Length > 0)
                    i++;
                if (i == last)
                    Buttons[btn].Enabled = true;
                else
                    Buttons[btn].Enabled = false;
            }
        }
    }
}