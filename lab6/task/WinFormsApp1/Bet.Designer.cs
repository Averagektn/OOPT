namespace L2_1
{
    partial class Bet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBet = new System.Windows.Forms.TextBox();
            this.rbOdd = new System.Windows.Forms.RadioButton();
            this.rbZero = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.gbValue = new System.Windows.Forms.GroupBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.gbValue.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBet
            // 
            this.tbBet.Location = new System.Drawing.Point(102, 49);
            this.tbBet.Name = "tbBet";
            this.tbBet.Size = new System.Drawing.Size(100, 26);
            this.tbBet.TabIndex = 0;
            this.tbBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // rbOdd
            // 
            this.rbOdd.AutoSize = true;
            this.rbOdd.Location = new System.Drawing.Point(6, 25);
            this.rbOdd.Name = "rbOdd";
            this.rbOdd.Size = new System.Drawing.Size(54, 23);
            this.rbOdd.TabIndex = 1;
            this.rbOdd.TabStop = true;
            this.rbOdd.Tag = "1";
            this.rbOdd.Text = "Odd";
            this.rbOdd.UseVisualStyleBackColor = true;
            // 
            // rbZero
            // 
            this.rbZero.AutoSize = true;
            this.rbZero.Location = new System.Drawing.Point(6, 22);
            this.rbZero.Name = "rbZero";
            this.rbZero.Size = new System.Drawing.Size(55, 23);
            this.rbZero.TabIndex = 2;
            this.rbZero.TabStop = true;
            this.rbZero.Tag = "0";
            this.rbZero.Text = "Zero";
            this.rbZero.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(6, 61);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(58, 23);
            this.rbBlack.TabIndex = 3;
            this.rbBlack.TabStop = true;
            this.rbBlack.Tag = "2";
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(6, 42);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(50, 23);
            this.rbRed.TabIndex = 4;
            this.rbRed.TabStop = true;
            this.rbRed.Tag = "1";
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbEven
            // 
            this.rbEven.AutoSize = true;
            this.rbEven.Location = new System.Drawing.Point(6, 54);
            this.rbEven.Name = "rbEven";
            this.rbEven.Size = new System.Drawing.Size(56, 23);
            this.rbEven.TabIndex = 5;
            this.rbEven.TabStop = true;
            this.rbEven.Tag = "0";
            this.rbEven.Text = "Even";
            this.rbEven.UseVisualStyleBackColor = true;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(102, 107);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 26);
            this.tbValue.TabIndex = 6;
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // gbValue
            // 
            this.gbValue.Controls.Add(this.rbEven);
            this.gbValue.Controls.Add(this.rbOdd);
            this.gbValue.Location = new System.Drawing.Point(29, 149);
            this.gbValue.Name = "gbValue";
            this.gbValue.Size = new System.Drawing.Size(100, 100);
            this.gbValue.TabIndex = 7;
            this.gbValue.TabStop = false;
            this.gbValue.Text = " Value";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbZero);
            this.gbColor.Location = new System.Drawing.Point(167, 149);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(100, 100);
            this.gbColor.TabIndex = 8;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(102, 27);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(29, 19);
            this.lblBet.TabIndex = 9;
            this.lblBet.Text = "Bet";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(102, 85);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 19);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Value";
            // 
            // Bet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbValue);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbBet);
            this.Name = "Bet";
            this.Text = "100";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bet_FormClosing);
            this.gbValue.ResumeLayout(false);
            this.gbValue.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBet;
        private RadioButton rbOdd;
        private RadioButton rbZero;
        private RadioButton rbBlack;
        private RadioButton rbRed;
        private RadioButton rbEven;
        private TextBox tbValue;
        private GroupBox gbValue;
        private GroupBox gbColor;
        private Label lblBet;
        private Label lblValue;
    }
}