using L2_1.Factories;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;
using WinFormsApp1.Factories;
using WinFormsApp1.Figures;

namespace WinFormsApp1
{
    /// <summary>
    /// The main form for the application.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// List of figures drawn on the PaintForm.
        /// </summary>
        public Figure? figures;

        private readonly PaintForm FormPaint;
        const string fileNameBIN = "save.bin";
        const string fileNameTXT = "save.txt";
        const string fileNameJSON = "save.json";

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            FormPaint = new PaintForm(this);
            if (File.Exists(fileNameJSON))
            {
                figures = Figure.DeserializeJSON(fileNameJSON);
                if (figures != null)
                {
                    FormPaint.Show();
                }
                else
                {
                    figures = new();
                }
            }
            else
            {
                figures = new();
            }
            Text = figures.Count();
        }

        /// <summary>
        /// Draws a figure on the PaintForm using the specified type, start point, and end point.
        /// </summary>
        /// <param name="type">The type of figure to draw.</param>
        /// <param name="p1">The starting point of the figure.</param>
        /// <param name="p2">The ending point of the figure.</param>
        private void Draw(Type type, Point p1, Point p2)
        {
            int ind;
            object? Factory = Activator.CreateInstance(type, p1, p2) as FigureFactory;
            MethodInfo? Create = type.GetMethod("Create");
            if (Create == null)
            {
                throw new ArgumentException($"Method not found");
            }
            if (figures == null)
            {
                throw new ArgumentException($"Figures not found");
            }

            FormPaint.Show();
            ind = figures.AddUnique((Create.Invoke(Factory, null) as Figure));
            FormPaint.Invalidate();
            figures[ind].Draw(FormPaint.graphics);
            Text = figures.Count();
        }

        /// <summary>
        /// Draws a figure on the PaintForm using the specified type, start point, end point, and file name.
        /// </summary>
        /// <param name="type">The type of figure to draw.</param>
        /// <param name="p1">The starting point of the figure.</param>
        /// <param name="p2">The ending point of the figure.</param>
        /// <param name="fileName">The file name to use when saving the figure.</param>
        private void Draw(Type type, Point p1, Point p2, string fileName)
        {
            int ind;
            object? Factory = Activator.CreateInstance(type, fileName, p1, p2) as FigureFactory;
            MethodInfo? Create = type.GetMethod("Create");
            if (Create == null)
            {
                throw new ArgumentException($"Method not found");
            }
            if (figures == null)
            {
                throw new ArgumentException($"Figures not found");
            }

            FormPaint.Show();
            ind = figures.AddUnique((Create.Invoke(Factory, null) as Figure));
            FormPaint.Invalidate();
            figures[ind].Draw(FormPaint.graphics);
            Text = figures.Count();
        }

        /// <summary>
        /// Draws a figure on the PaintForm using the specified type, start point, end point, start angle, and sweep angle.
        /// </summary>
        /// <param name="type">The type of figure to draw.</param>
        /// <param name="p1">The starting point of the figure.</param>
        /// <param name="p2">The ending point of the figure.</param>
        /// <param name="startAngle">The start angle of the figure (for arc and pie shapes).</param>
        /// <param name="sweepAngle">The sweep angle of the figure (for arc and pie shapes).</param>
        private void Draw(Type type, Point p1, Point p2, int startAngle, int sweepAngle)
        {
            int ind;
            object? Factory = Activator.CreateInstance(type, p1, p2, startAngle, sweepAngle) as FigureFactory;
            MethodInfo? Create = type.GetMethod("Create");
            if (Create == null)
            {
                throw new ArgumentException($"Method not found");
            }
            if (figures == null)
            {
                throw new ArgumentException($"Figures not found");
            }
            FormPaint.Show();
            ind = figures.AddUnique((Create.Invoke(Factory, null) as Figure));
            FormPaint.Invalidate();
            figures[ind].Draw(FormPaint.graphics);
            Text = figures.Count();
        }

        /// <summary>
        /// Draws a line on the PaintForm using the specified starting and ending points.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawLine_Click(object sender, EventArgs e)
        {
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            Draw(typeof(LineFactory), p1, p2);
        }

        /// <summary>
        /// Draws a rectangle on the PaintForm using the specified starting and ending points.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawRect_Click(object sender, EventArgs e)
        {
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            Draw(typeof(RectFactory), p1, p2);
        }

        /// <summary>
        /// Draws an ellipse on the PaintForm using the specified starting and ending points.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawEllipse_Click(object sender, EventArgs e)
        {
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            Draw(typeof(EllipseFactory), p1, p2);
        }

        /// <summary>
        /// Draws an arc on the PaintForm using the specified starting and ending points, start angle, and sweep angle.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawArc_Click(object sender, EventArgs e)
        {
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            int startAngle = Convert.ToInt32(tbStartAngle.Text);
            int sweepAngle = Convert.ToInt32(tbSweepAngle.Text);
            Draw(typeof(ArcFactory), p1, p2, startAngle, sweepAngle);
        }

        /// <summary>
        /// Opens a file dialog to select an image file and draws it on the PaintForm using the specified starting and ending points.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawImage_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            if (filePath != string.Empty)
            {
                Draw(typeof(ImageFactory), p1, p2, filePath);
            }
        }

        /// <summary>
        /// Draws a pie shape on the PaintForm using the specified starting and ending points, start angle, and sweep angle.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DrawPie_Click(object sender, EventArgs e)
        {
            Point p1 = new(Convert.ToInt32(tbX1.Text), Convert.ToInt32(tbY1.Text));
            Point p2 = new(Convert.ToInt32(tbX2.Text), Convert.ToInt32(tbY2.Text));
            int startAngle = Convert.ToInt32(tbStartAngle.Text);
            int sweepAngle = Convert.ToInt32(tbSweepAngle.Text);
            Draw(typeof(PieFactory), p1, p2, startAngle, sweepAngle);
        }

        ///<summary>
        ///Enables or disables the draw buttons based on whether the required text boxes are filled in.
        ///</summary>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (tbX1.Text != string.Empty && tbX2.Text != string.Empty && tbY1.Text != string.Empty && tbY2.Text != string.Empty)
            {

                btnDrawEllipse.Enabled = true;
                btnDrawRect.Enabled = true;
                btnDrawLine.Enabled = true;
                btnDrawImage.Enabled = true;
                if (tbStartAngle.Text != string.Empty && tbSweepAngle.Text != string.Empty)
                {
                    btnDrawArc.Enabled = true;
                    btnDrawPie.Enabled = true;
                }
                else
                {
                    btnDrawArc.Enabled = false;
                    btnDrawPie.Enabled = false;
                }
            }
            else
            {
                btnDrawEllipse.Enabled = false;
                btnDrawRect.Enabled = false;
                btnDrawLine.Enabled = false;
                btnDrawArc.Enabled = false;
                btnDrawPie.Enabled = false;
                btnDrawImage.Enabled = false;
            }
        }

        ///<summary>
        ///Checks if the key pressed is a digit or backspace and handles it accordingly.
        ///</summary>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
            {
                e.Handled = true;
            }
        }

        ///<summary>
        ///Executed when the form is closing. Serializes the figures to JSON, TXT, and BIN files.
        ///</summary>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Figure.SerializeJSON(fileNameJSON, figures);
            Figure.SerializeTXT(fileNameTXT, figures);
            Figure.SerializeBIN(fileNameBIN, figures);
        }
    }
}