using System.Drawing;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public List<Line> figures = new List<Line>();
        
        PaintForm formPaint;
        TextBox[] textBoxes;
        Button[] buttons;
        public Main()
        {
            InitializeComponent();
            formPaint = new PaintForm(this);
            Text = Line.Count();
            textBoxes = new TextBox[] { tbArcX1, tbArcY2, tbArcX2, tbArcY2, tbArcStartAngle, tbArcSweepAngle, tbEllipseX, tbEllipseY, 
                tbEllipseWidth, tbEllipseHeight, tbRectX, tbRectY, tbRectWidth, tbRectHeight, tbLineX1, tbLineY1, tbLineX2, tbLineY2 };
            buttons = new Button[] { btnDrawArc, btnDrawEllipse, btnDrawRect, btnDrawLine };
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
            {
                e.Handled = true;
            }
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            formPaint.Show();
            Point p1 = new Point(Convert.ToInt32(tbLineX1.Text), Convert.ToInt32(tbLineY1.Text));
            Point p2 = new Point(Convert.ToInt32(tbLineX2.Text), Convert.ToInt32(tbLineY2.Text));
            figures.Add(new Line(p1, p2));
            figures[figures.Count - 1].Draw(formPaint.graphics);
            Text = Line.Count();
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            formPaint.Show();
            Point p = new Point(Convert.ToInt32(tbRectX.Text), Convert.ToInt32(tbRectY.Text));
            int width = Convert.ToInt32(tbRectWidth.Text);
            int height = Convert.ToInt32(tbRectHeight.Text);
            figures.Add(new Rectangle(p, width, height));
            figures[figures.Count - 1].Draw(formPaint.graphics);
            Text = Line.Count();
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            formPaint.Show();
            Point p = new Point(Convert.ToInt32(tbEllipseX.Text), Convert.ToInt32(tbEllipseY.Text));
            int width = Convert.ToInt32(tbEllipseWidth.Text);
            int height = Convert.ToInt32(tbEllipseHeight.Text);
            figures.Add(new Ellipse(p, width, height));
            figures[figures.Count - 1].Draw(formPaint.graphics);
            Text = Line.Count();
        }

        private void btnDrawArc_Click(object sender, EventArgs e)
        {
            formPaint.Show();
            Point p1 = new Point(Convert.ToInt32(tbArcX1.Text), Convert.ToInt32(tbArcY1.Text));
            Point p2 = new Point(Convert.ToInt32(tbArcX2.Text), Convert.ToInt32(tbArcY2.Text));
            int startAngle = Convert.ToInt32(tbArcStartAngle.Text);
            int sweepAngle = Convert.ToInt32(tbArcSweepAngle.Text);
            Arc arc = new Arc(p1, p2, startAngle, sweepAngle);
            arc.Draw(formPaint.graphics);
            figures.Add(arc);
 
            Text = Line.Count();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag), i = 0;
            const int TB_ARCS = 6, TB_DEFAULT = 4, BTN_ARC = 0;
            if (index < TB_ARCS)
            {
                while(i < TB_ARCS && textBoxes[i].Text.Length > 0)
                {
                    i++;
                }
                if (i == TB_ARCS)
                {
                    buttons[BTN_ARC].Enabled = true;
                }
                else
                {
                    buttons[BTN_ARC].Enabled = false;
                }
            }
            else
            {
                int last = ((index - TB_ARCS) / TB_DEFAULT) * TB_DEFAULT + TB_DEFAULT + TB_ARCS, btn = (index - TB_ARCS) / TB_DEFAULT + 1;
                i = last - TB_DEFAULT;
                while (i < last && textBoxes[i].Text.Length > 0)
                {
                    i++;
                }
                if (i == last)
                {
                    buttons[btn].Enabled = true;
                }
                else
                {
                    buttons[btn].Enabled = false;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}