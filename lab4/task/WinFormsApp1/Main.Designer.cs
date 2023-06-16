namespace WinFormsApp1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.btnDrawEllipse = new System.Windows.Forms.Button();
            this.btnDrawArc = new System.Windows.Forms.Button();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbStartAngle = new System.Windows.Forms.TextBox();
            this.tbSweepAngle = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.lblRotateAngle = new System.Windows.Forms.Label();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadDLL = new System.Windows.Forms.Button();
            this.openFileDialogDll = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(50, 250);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(100, 50);
            this.btnDrawLine.TabIndex = 6;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Location = new System.Drawing.Point(200, 250);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(100, 50);
            this.btnDrawRect.TabIndex = 7;
            this.btnDrawRect.Text = "Draw Rectangle";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.Location = new System.Drawing.Point(200, 300);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(100, 50);
            this.btnDrawEllipse.TabIndex = 8;
            this.btnDrawEllipse.Text = "Draw Ellipse";
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // btnDrawArc
            // 
            this.btnDrawArc.Location = new System.Drawing.Point(50, 300);
            this.btnDrawArc.Name = "btnDrawArc";
            this.btnDrawArc.Size = new System.Drawing.Size(100, 50);
            this.btnDrawArc.TabIndex = 9;
            this.btnDrawArc.Text = "Draw Arc";
            this.btnDrawArc.UseVisualStyleBackColor = true;
            this.btnDrawArc.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(122, 43);
            this.tbX1.MaxLength = 3;
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(43, 26);
            this.tbX1.TabIndex = 0;
            this.tbX1.Tag = "\"tb\"";
            this.tbX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(182, 43);
            this.tbY1.MaxLength = 3;
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(43, 26);
            this.tbY1.TabIndex = 1;
            this.tbY1.Tag = "\"tb\"";
            // 
            // tbStartAngle
            // 
            this.tbStartAngle.Location = new System.Drawing.Point(122, 198);
            this.tbStartAngle.MaxLength = 3;
            this.tbStartAngle.Name = "tbStartAngle";
            this.tbStartAngle.Size = new System.Drawing.Size(40, 26);
            this.tbStartAngle.TabIndex = 4;
            this.tbStartAngle.Tag = "\"tb\"";
            this.tbStartAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbSweepAngle
            // 
            this.tbSweepAngle.Location = new System.Drawing.Point(182, 198);
            this.tbSweepAngle.MaxLength = 3;
            this.tbSweepAngle.Name = "tbSweepAngle";
            this.tbSweepAngle.Size = new System.Drawing.Size(40, 26);
            this.tbSweepAngle.TabIndex = 5;
            this.tbSweepAngle.Tag = "\"tb\"";
            this.tbSweepAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(122, 123);
            this.tbX2.MaxLength = 3;
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(43, 26);
            this.tbX2.TabIndex = 2;
            this.tbX2.Tag = "\"tb\"";
            this.tbX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(182, 123);
            this.tbY2.MaxLength = 3;
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(43, 26);
            this.tbY2.TabIndex = 3;
            this.tbY2.Tag = "\"tb\"";
            this.tbY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(122, 21);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(25, 19);
            this.lblX1.TabIndex = 23;
            this.lblX1.Text = "X1";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(182, 21);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(25, 19);
            this.lblY1.TabIndex = 27;
            this.lblY1.Text = "Y1";
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Location = new System.Drawing.Point(182, 101);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(25, 19);
            this.lblY2.TabIndex = 37;
            this.lblY2.Text = "Y2";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(122, 101);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(25, 19);
            this.lblX2.TabIndex = 38;
            this.lblX2.Text = "X2";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(87, 176);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(75, 19);
            this.lblStartAngle.TabIndex = 39;
            this.lblStartAngle.Text = "Start angle";
            // 
            // lblRotateAngle
            // 
            this.lblRotateAngle.AutoSize = true;
            this.lblRotateAngle.Location = new System.Drawing.Point(182, 176);
            this.lblRotateAngle.Name = "lblRotateAngle";
            this.lblRotateAngle.Size = new System.Drawing.Size(86, 19);
            this.lblRotateAngle.TabIndex = 40;
            this.lblRotateAngle.Text = "Rotate angle";
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.Filter = "Bitmap (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|Joint Photographic" +
    " Experts Group (*.jpeg)|*.jpeg|Portable Network Graphics (*.png)|*.png|Tagged Im" +
    "age File Format (*.tiff)|*.tiff";
            this.openFileDialogPicture.InitialDirectory = "C:\\\\";
            this.openFileDialogPicture.Title = "Choose file";
            // 
            // btnLoadDLL
            // 
            this.btnLoadDLL.Location = new System.Drawing.Point(125, 356);
            this.btnLoadDLL.Name = "btnLoadDLL";
            this.btnLoadDLL.Size = new System.Drawing.Size(100, 50);
            this.btnLoadDLL.TabIndex = 41;
            this.btnLoadDLL.Text = "Add dll...";
            this.btnLoadDLL.UseVisualStyleBackColor = true;
            this.btnLoadDLL.Click += new System.EventHandler(this.LoadDLL_Click);
            // 
            // openFileDialogDll
            // 
            this.openFileDialogDll.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 461);
            this.Controls.Add(this.btnLoadDLL);
            this.Controls.Add(this.lblRotateAngle);
            this.Controls.Add(this.lblStartAngle);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbSweepAngle);
            this.Controls.Add(this.tbStartAngle);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.btnDrawArc);
            this.Controls.Add(this.btnDrawEllipse);
            this.Controls.Add(this.btnDrawRect);
            this.Controls.Add(this.btnDrawLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDrawLine;

        private Button btnDrawRect;

        private Button btnDrawEllipse;

        private Button btnDrawArc;
        private TextBox tbX1;
        private TextBox tbY1;
        private TextBox tbStartAngle;
        private TextBox tbSweepAngle;
        private TextBox tbX2;
        private TextBox tbY2;

        private Label lblX1;
        private Label lblY1;
        private Label lblY2;
        private Label lblX2;
        private Label lblStartAngle;
        private Label lblRotateAngle;
        private OpenFileDialog openFileDialogPicture;
        private Button btnLoadDLL;
        private OpenFileDialog openFileDialogDll;
    }
}