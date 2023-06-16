using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PaintForm : Form
    {
        public Graphics graphics;
        Main main;

        public PaintForm(Main main)
        {
            InitializeComponent();
            graphics= CreateGraphics();
            this.main = main;
        }

        private void PaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < main.figures.Count; i++)
            {
                main.figures[i].Draw(graphics);
            }
        }
    }
}
