using static L2_1.Patterns.Behavior.Sector;

namespace L2_1
{
    public partial class Bet : Form
    {
        public Bet()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            tbValue.Clear();
            tbBet.Clear();
            rbBlack.Checked = false;
            rbEven.Checked = false;
            rbOdd.Checked = false;
            rbZero.Checked = false;
            rbRed.Checked = false;
        }
        public Colors? GetColor()
        {
            if (rbZero.Checked)
            {
                return Colors.Zero;
            }
            else if (rbRed.Checked)
            {
                return Colors.Red;
            }
            else if (rbBlack.Checked)
            {
                return Colors.Black;
            }
            return null;
        }
        public bool? IsOdd()
        {
            if (rbOdd.Checked)
            {
                return true;
            }
            else if (rbEven.Checked)
            {
                return false;
            }
            return null;
        }
        public int GetBet()
        {
            return int.Parse(tbBet.Text);
        }
        public int GetValue()
        {
            int res;
            if (string.IsNullOrEmpty(tbValue.Text))
            {
                res = 0;
            }
            else
            {
                res = int.Parse(tbValue.Text);
            }
            return res;
        }

        /// <summary>
        /// Event handler for key press events of text boxes.
        /// Allows only digits and backspace key to be entered.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="KeyPressEventArgs"/> that contains the event data.</param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != BACKSPACE)
            {
                e.Handled = true;
            }
        }

        private void Bet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBet.Text))
            {
                if (string.IsNullOrEmpty(tbValue.Text) && IsOdd() == null && GetColor() == null)
                {
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
