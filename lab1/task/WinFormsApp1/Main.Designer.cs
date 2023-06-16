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
            this.tbLineX1 = new System.Windows.Forms.TextBox();
            this.tbLineY1 = new System.Windows.Forms.TextBox();
            this.tbLineX2 = new System.Windows.Forms.TextBox();
            this.tbLineY2 = new System.Windows.Forms.TextBox();
            this.tbRectX = new System.Windows.Forms.TextBox();
            this.tbRectY = new System.Windows.Forms.TextBox();
            this.tbRectWidth = new System.Windows.Forms.TextBox();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.tbRectHeight = new System.Windows.Forms.TextBox();
            this.btnDrawEllipse = new System.Windows.Forms.Button();
            this.tbEllipseX = new System.Windows.Forms.TextBox();
            this.tbEllipseY = new System.Windows.Forms.TextBox();
            this.tbEllipseWidth = new System.Windows.Forms.TextBox();
            this.tbEllipseHeight = new System.Windows.Forms.TextBox();
            this.btnDrawArc = new System.Windows.Forms.Button();
            this.tbArcX1 = new System.Windows.Forms.TextBox();
            this.tbArcY1 = new System.Windows.Forms.TextBox();
            this.tbArcStartAngle = new System.Windows.Forms.TextBox();
            this.tbArcSweepAngle = new System.Windows.Forms.TextBox();
            this.tbArcX2 = new System.Windows.Forms.TextBox();
            this.tbArcY2 = new System.Windows.Forms.TextBox();
            this.lblArcX1 = new System.Windows.Forms.Label();
            this.lblEllipseX1 = new System.Windows.Forms.Label();
            this.lblRectX1 = new System.Windows.Forms.Label();
            this.lblLineX1 = new System.Windows.Forms.Label();
            this.lblArcY1 = new System.Windows.Forms.Label();
            this.lblEllipseY1 = new System.Windows.Forms.Label();
            this.lblRectY1 = new System.Windows.Forms.Label();
            this.lblLineY1 = new System.Windows.Forms.Label();
            this.lblLineY2 = new System.Windows.Forms.Label();
            this.lblLineX2 = new System.Windows.Forms.Label();
            this.lblRectHeight = new System.Windows.Forms.Label();
            this.lblRectWidth = new System.Windows.Forms.Label();
            this.lblEllipseHeight = new System.Windows.Forms.Label();
            this.lblEllipseWidth = new System.Windows.Forms.Label();
            this.lblArcY2 = new System.Windows.Forms.Label();
            this.lblArcX2 = new System.Windows.Forms.Label();
            this.lblArcStartAngle = new System.Windows.Forms.Label();
            this.lblArcRotateAngle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Enabled = false;
            this.btnDrawLine.Location = new System.Drawing.Point(560, 280);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(140, 80);
            this.btnDrawLine.TabIndex = 22;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // tbLineX1
            // 
            this.tbLineX1.Location = new System.Drawing.Point(570, 60);
            this.tbLineX1.MaxLength = 3;
            this.tbLineX1.Name = "tbLineX1";
            this.tbLineX1.Size = new System.Drawing.Size(43, 26);
            this.tbLineX1.TabIndex = 17;
            this.tbLineX1.Tag = "14";
            this.tbLineX1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbLineX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbLineY1
            // 
            this.tbLineY1.Location = new System.Drawing.Point(650, 60);
            this.tbLineY1.MaxLength = 3;
            this.tbLineY1.Name = "tbLineY1";
            this.tbLineY1.Size = new System.Drawing.Size(43, 26);
            this.tbLineY1.TabIndex = 19;
            this.tbLineY1.Tag = "16";
            this.tbLineY1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbLineY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbLineX2
            // 
            this.tbLineX2.Location = new System.Drawing.Point(570, 140);
            this.tbLineX2.MaxLength = 3;
            this.tbLineX2.Name = "tbLineX2";
            this.tbLineX2.Size = new System.Drawing.Size(43, 26);
            this.tbLineX2.TabIndex = 20;
            this.tbLineX2.Tag = "15";
            this.tbLineX2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbLineX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbLineY2
            // 
            this.tbLineY2.Location = new System.Drawing.Point(650, 140);
            this.tbLineY2.MaxLength = 3;
            this.tbLineY2.Name = "tbLineY2";
            this.tbLineY2.Size = new System.Drawing.Size(43, 26);
            this.tbLineY2.TabIndex = 21;
            this.tbLineY2.Tag = "17";
            this.tbLineY2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbLineY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbRectX
            // 
            this.tbRectX.Location = new System.Drawing.Point(390, 60);
            this.tbRectX.MaxLength = 3;
            this.tbRectX.Name = "tbRectX";
            this.tbRectX.Size = new System.Drawing.Size(43, 26);
            this.tbRectX.TabIndex = 12;
            this.tbRectX.Tag = "10";
            this.tbRectX.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbRectX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbRectY
            // 
            this.tbRectY.Location = new System.Drawing.Point(470, 60);
            this.tbRectY.MaxLength = 3;
            this.tbRectY.Name = "tbRectY";
            this.tbRectY.Size = new System.Drawing.Size(43, 26);
            this.tbRectY.TabIndex = 13;
            this.tbRectY.Tag = "11";
            this.tbRectY.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbRectY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbRectWidth
            // 
            this.tbRectWidth.Location = new System.Drawing.Point(390, 140);
            this.tbRectWidth.MaxLength = 3;
            this.tbRectWidth.Name = "tbRectWidth";
            this.tbRectWidth.Size = new System.Drawing.Size(43, 26);
            this.tbRectWidth.TabIndex = 14;
            this.tbRectWidth.Tag = "12";
            this.tbRectWidth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbRectWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Enabled = false;
            this.btnDrawRect.Location = new System.Drawing.Point(380, 280);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(140, 80);
            this.btnDrawRect.TabIndex = 16;
            this.btnDrawRect.Text = "Draw Rectangle";
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // tbRectHeight
            // 
            this.tbRectHeight.Location = new System.Drawing.Point(470, 140);
            this.tbRectHeight.MaxLength = 3;
            this.tbRectHeight.Name = "tbRectHeight";
            this.tbRectHeight.Size = new System.Drawing.Size(43, 26);
            this.tbRectHeight.TabIndex = 15;
            this.tbRectHeight.Tag = "13";
            this.tbRectHeight.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbRectHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.Enabled = false;
            this.btnDrawEllipse.Location = new System.Drawing.Point(200, 280);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(140, 80);
            this.btnDrawEllipse.TabIndex = 11;
            this.btnDrawEllipse.Text = "Draw Ellipse";
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.Click += new System.EventHandler(this.btnDrawEllipse_Click);
            // 
            // tbEllipseX
            // 
            this.tbEllipseX.Location = new System.Drawing.Point(210, 60);
            this.tbEllipseX.MaxLength = 3;
            this.tbEllipseX.Name = "tbEllipseX";
            this.tbEllipseX.Size = new System.Drawing.Size(43, 26);
            this.tbEllipseX.TabIndex = 7;
            this.tbEllipseX.Tag = "6";
            this.tbEllipseX.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbEllipseX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbEllipseY
            // 
            this.tbEllipseY.Location = new System.Drawing.Point(290, 60);
            this.tbEllipseY.MaxLength = 3;
            this.tbEllipseY.Name = "tbEllipseY";
            this.tbEllipseY.Size = new System.Drawing.Size(43, 26);
            this.tbEllipseY.TabIndex = 8;
            this.tbEllipseY.Tag = "7";
            this.tbEllipseY.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbEllipseY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbEllipseWidth
            // 
            this.tbEllipseWidth.Location = new System.Drawing.Point(210, 140);
            this.tbEllipseWidth.MaxLength = 3;
            this.tbEllipseWidth.Name = "tbEllipseWidth";
            this.tbEllipseWidth.Size = new System.Drawing.Size(43, 26);
            this.tbEllipseWidth.TabIndex = 9;
            this.tbEllipseWidth.Tag = "8";
            this.tbEllipseWidth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbEllipseWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbEllipseHeight
            // 
            this.tbEllipseHeight.Location = new System.Drawing.Point(290, 140);
            this.tbEllipseHeight.MaxLength = 3;
            this.tbEllipseHeight.Name = "tbEllipseHeight";
            this.tbEllipseHeight.Size = new System.Drawing.Size(43, 26);
            this.tbEllipseHeight.TabIndex = 10;
            this.tbEllipseHeight.Tag = "9";
            this.tbEllipseHeight.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbEllipseHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnDrawArc
            // 
            this.btnDrawArc.Enabled = false;
            this.btnDrawArc.Location = new System.Drawing.Point(20, 280);
            this.btnDrawArc.Name = "btnDrawArc";
            this.btnDrawArc.Size = new System.Drawing.Size(140, 80);
            this.btnDrawArc.TabIndex = 6;
            this.btnDrawArc.Text = "Draw Arc";
            this.btnDrawArc.UseVisualStyleBackColor = true;
            this.btnDrawArc.Click += new System.EventHandler(this.btnDrawArc_Click);
            // 
            // tbArcX1
            // 
            this.tbArcX1.Location = new System.Drawing.Point(30, 60);
            this.tbArcX1.MaxLength = 3;
            this.tbArcX1.Name = "tbArcX1";
            this.tbArcX1.Size = new System.Drawing.Size(43, 26);
            this.tbArcX1.TabIndex = 0;
            this.tbArcX1.Tag = "0";
            this.tbArcX1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbArcX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbArcY1
            // 
            this.tbArcY1.Location = new System.Drawing.Point(107, 60);
            this.tbArcY1.MaxLength = 3;
            this.tbArcY1.Name = "tbArcY1";
            this.tbArcY1.Size = new System.Drawing.Size(43, 26);
            this.tbArcY1.TabIndex = 1;
            this.tbArcY1.Tag = "1";
            this.tbArcY1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // tbArcStartAngle
            // 
            this.tbArcStartAngle.Location = new System.Drawing.Point(30, 220);
            this.tbArcStartAngle.MaxLength = 3;
            this.tbArcStartAngle.Name = "tbArcStartAngle";
            this.tbArcStartAngle.Size = new System.Drawing.Size(40, 26);
            this.tbArcStartAngle.TabIndex = 4;
            this.tbArcStartAngle.Tag = "4";
            this.tbArcStartAngle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbArcStartAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbArcSweepAngle
            // 
            this.tbArcSweepAngle.Location = new System.Drawing.Point(110, 220);
            this.tbArcSweepAngle.MaxLength = 3;
            this.tbArcSweepAngle.Name = "tbArcSweepAngle";
            this.tbArcSweepAngle.Size = new System.Drawing.Size(40, 26);
            this.tbArcSweepAngle.TabIndex = 5;
            this.tbArcSweepAngle.Tag = "5";
            this.tbArcSweepAngle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbArcSweepAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbArcX2
            // 
            this.tbArcX2.Location = new System.Drawing.Point(30, 140);
            this.tbArcX2.MaxLength = 3;
            this.tbArcX2.Name = "tbArcX2";
            this.tbArcX2.Size = new System.Drawing.Size(43, 26);
            this.tbArcX2.TabIndex = 2;
            this.tbArcX2.Tag = "2";
            this.tbArcX2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbArcX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tbArcY2
            // 
            this.tbArcY2.Location = new System.Drawing.Point(107, 140);
            this.tbArcY2.MaxLength = 3;
            this.tbArcY2.Name = "tbArcY2";
            this.tbArcY2.Size = new System.Drawing.Size(43, 26);
            this.tbArcY2.TabIndex = 3;
            this.tbArcY2.Tag = "3";
            this.tbArcY2.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.tbArcY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // lblArcX1
            // 
            this.lblArcX1.AutoSize = true;
            this.lblArcX1.Location = new System.Drawing.Point(40, 30);
            this.lblArcX1.Name = "lblArcX1";
            this.lblArcX1.Size = new System.Drawing.Size(25, 19);
            this.lblArcX1.TabIndex = 23;
            this.lblArcX1.Text = "X1";
            // 
            // lblEllipseX1
            // 
            this.lblEllipseX1.AutoSize = true;
            this.lblEllipseX1.Location = new System.Drawing.Point(220, 30);
            this.lblEllipseX1.Name = "lblEllipseX1";
            this.lblEllipseX1.Size = new System.Drawing.Size(25, 19);
            this.lblEllipseX1.TabIndex = 24;
            this.lblEllipseX1.Text = "X1";
            // 
            // lblRectX1
            // 
            this.lblRectX1.AutoSize = true;
            this.lblRectX1.Location = new System.Drawing.Point(400, 30);
            this.lblRectX1.Name = "lblRectX1";
            this.lblRectX1.Size = new System.Drawing.Size(25, 19);
            this.lblRectX1.TabIndex = 25;
            this.lblRectX1.Text = "X1";
            // 
            // lblLineX1
            // 
            this.lblLineX1.AutoSize = true;
            this.lblLineX1.Location = new System.Drawing.Point(580, 30);
            this.lblLineX1.Name = "lblLineX1";
            this.lblLineX1.Size = new System.Drawing.Size(25, 19);
            this.lblLineX1.TabIndex = 26;
            this.lblLineX1.Text = "X1";
            // 
            // lblArcY1
            // 
            this.lblArcY1.AutoSize = true;
            this.lblArcY1.Location = new System.Drawing.Point(117, 30);
            this.lblArcY1.Name = "lblArcY1";
            this.lblArcY1.Size = new System.Drawing.Size(25, 19);
            this.lblArcY1.TabIndex = 27;
            this.lblArcY1.Text = "Y1";
            // 
            // lblEllipseY1
            // 
            this.lblEllipseY1.AutoSize = true;
            this.lblEllipseY1.Location = new System.Drawing.Point(300, 30);
            this.lblEllipseY1.Name = "lblEllipseY1";
            this.lblEllipseY1.Size = new System.Drawing.Size(25, 19);
            this.lblEllipseY1.TabIndex = 28;
            this.lblEllipseY1.Text = "Y1";
            // 
            // lblRectY1
            // 
            this.lblRectY1.AutoSize = true;
            this.lblRectY1.Location = new System.Drawing.Point(480, 30);
            this.lblRectY1.Name = "lblRectY1";
            this.lblRectY1.Size = new System.Drawing.Size(25, 19);
            this.lblRectY1.TabIndex = 29;
            this.lblRectY1.Text = "Y1";
            // 
            // lblLineY1
            // 
            this.lblLineY1.AutoSize = true;
            this.lblLineY1.Location = new System.Drawing.Point(660, 30);
            this.lblLineY1.Name = "lblLineY1";
            this.lblLineY1.Size = new System.Drawing.Size(25, 19);
            this.lblLineY1.TabIndex = 30;
            this.lblLineY1.Text = "Y1";
            // 
            // lblLineY2
            // 
            this.lblLineY2.AutoSize = true;
            this.lblLineY2.Location = new System.Drawing.Point(660, 108);
            this.lblLineY2.Name = "lblLineY2";
            this.lblLineY2.Size = new System.Drawing.Size(25, 19);
            this.lblLineY2.TabIndex = 31;
            this.lblLineY2.Text = "Y2";
            // 
            // lblLineX2
            // 
            this.lblLineX2.AutoSize = true;
            this.lblLineX2.Location = new System.Drawing.Point(580, 108);
            this.lblLineX2.Name = "lblLineX2";
            this.lblLineX2.Size = new System.Drawing.Size(25, 19);
            this.lblLineX2.TabIndex = 32;
            this.lblLineX2.Text = "X2";
            // 
            // lblRectHeight
            // 
            this.lblRectHeight.AutoSize = true;
            this.lblRectHeight.Location = new System.Drawing.Point(465, 110);
            this.lblRectHeight.Name = "lblRectHeight";
            this.lblRectHeight.Size = new System.Drawing.Size(50, 19);
            this.lblRectHeight.TabIndex = 33;
            this.lblRectHeight.Text = "Height";
            // 
            // lblRectWidth
            // 
            this.lblRectWidth.AutoSize = true;
            this.lblRectWidth.Location = new System.Drawing.Point(388, 108);
            this.lblRectWidth.Name = "lblRectWidth";
            this.lblRectWidth.Size = new System.Drawing.Size(46, 19);
            this.lblRectWidth.TabIndex = 34;
            this.lblRectWidth.Text = "Width";
            // 
            // lblEllipseHeight
            // 
            this.lblEllipseHeight.AutoSize = true;
            this.lblEllipseHeight.Location = new System.Drawing.Point(285, 108);
            this.lblEllipseHeight.Name = "lblEllipseHeight";
            this.lblEllipseHeight.Size = new System.Drawing.Size(50, 19);
            this.lblEllipseHeight.TabIndex = 35;
            this.lblEllipseHeight.Text = "Height";
            // 
            // lblEllipseWidth
            // 
            this.lblEllipseWidth.AutoSize = true;
            this.lblEllipseWidth.Location = new System.Drawing.Point(210, 108);
            this.lblEllipseWidth.Name = "lblEllipseWidth";
            this.lblEllipseWidth.Size = new System.Drawing.Size(46, 19);
            this.lblEllipseWidth.TabIndex = 36;
            this.lblEllipseWidth.Text = "Width";
            // 
            // lblArcY2
            // 
            this.lblArcY2.AutoSize = true;
            this.lblArcY2.Location = new System.Drawing.Point(117, 110);
            this.lblArcY2.Name = "lblArcY2";
            this.lblArcY2.Size = new System.Drawing.Size(25, 19);
            this.lblArcY2.TabIndex = 37;
            this.lblArcY2.Text = "Y2";
            // 
            // lblArcX2
            // 
            this.lblArcX2.AutoSize = true;
            this.lblArcX2.Location = new System.Drawing.Point(40, 110);
            this.lblArcX2.Name = "lblArcX2";
            this.lblArcX2.Size = new System.Drawing.Size(25, 19);
            this.lblArcX2.TabIndex = 38;
            this.lblArcX2.Text = "X2";
            // 
            // lblArcStartAngle
            // 
            this.lblArcStartAngle.AutoSize = true;
            this.lblArcStartAngle.Location = new System.Drawing.Point(12, 190);
            this.lblArcStartAngle.Name = "lblArcStartAngle";
            this.lblArcStartAngle.Size = new System.Drawing.Size(75, 19);
            this.lblArcStartAngle.TabIndex = 39;
            this.lblArcStartAngle.Text = "Start angle";
            // 
            // lblArcRotateAngle
            // 
            this.lblArcRotateAngle.AutoSize = true;
            this.lblArcRotateAngle.Location = new System.Drawing.Point(84, 190);
            this.lblArcRotateAngle.Name = "lblArcRotateAngle";
            this.lblArcRotateAngle.Size = new System.Drawing.Size(86, 19);
            this.lblArcRotateAngle.TabIndex = 40;
            this.lblArcRotateAngle.Text = "Rotate angle";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.lblArcRotateAngle);
            this.Controls.Add(this.lblArcStartAngle);
            this.Controls.Add(this.lblArcX2);
            this.Controls.Add(this.lblArcY2);
            this.Controls.Add(this.lblEllipseWidth);
            this.Controls.Add(this.lblEllipseHeight);
            this.Controls.Add(this.lblRectWidth);
            this.Controls.Add(this.lblRectHeight);
            this.Controls.Add(this.lblLineX2);
            this.Controls.Add(this.lblLineY2);
            this.Controls.Add(this.lblLineY1);
            this.Controls.Add(this.lblRectY1);
            this.Controls.Add(this.lblEllipseY1);
            this.Controls.Add(this.lblArcY1);
            this.Controls.Add(this.lblLineX1);
            this.Controls.Add(this.lblRectX1);
            this.Controls.Add(this.lblEllipseX1);
            this.Controls.Add(this.lblArcX1);
            this.Controls.Add(this.tbArcY2);
            this.Controls.Add(this.tbArcX2);
            this.Controls.Add(this.tbArcSweepAngle);
            this.Controls.Add(this.tbArcStartAngle);
            this.Controls.Add(this.tbArcY1);
            this.Controls.Add(this.tbArcX1);
            this.Controls.Add(this.btnDrawArc);
            this.Controls.Add(this.tbEllipseHeight);
            this.Controls.Add(this.tbEllipseWidth);
            this.Controls.Add(this.tbEllipseY);
            this.Controls.Add(this.tbEllipseX);
            this.Controls.Add(this.btnDrawEllipse);
            this.Controls.Add(this.tbRectHeight);
            this.Controls.Add(this.btnDrawRect);
            this.Controls.Add(this.tbRectWidth);
            this.Controls.Add(this.tbRectY);
            this.Controls.Add(this.tbRectX);
            this.Controls.Add(this.tbLineY2);
            this.Controls.Add(this.tbLineX2);
            this.Controls.Add(this.tbLineY1);
            this.Controls.Add(this.tbLineX1);
            this.Controls.Add(this.btnDrawLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDrawLine;
        private TextBox tbLineX1;
        private TextBox tbLineY1;
        private TextBox tbLineX2;
        private TextBox tbLineY2;

        private Button btnDrawRect;
        private TextBox tbRectX;
        private TextBox tbRectY;
        private TextBox tbRectWidth;
        private TextBox tbRectHeight;

        private Button btnDrawEllipse;
        private TextBox tbEllipseX;
        private TextBox tbEllipseY;
        private TextBox tbEllipseWidth;
        private TextBox tbEllipseHeight;

        private Button btnDrawArc;
        private TextBox tbArcX1;
        private TextBox tbArcY1;
        private TextBox tbArcStartAngle;
        private TextBox tbArcSweepAngle;
        private TextBox tbArcX2;
        private TextBox tbArcY2;

        private Label lblArcX1;
        private Label lblEllipseX1;
        private Label lblRectX1;
        private Label lblLineX1;
        private Label lblArcY1;
        private Label lblEllipseY1;
        private Label lblRectY1;
        private Label lblLineY1;
        private Label lblLineY2;
        private Label lblLineX2;
        private Label lblRectHeight;
        private Label lblRectWidth;
        private Label lblEllipseHeight;
        private Label lblEllipseWidth;
        private Label lblArcY2;
        private Label lblArcX2;
        private Label lblArcStartAngle;
        private Label lblArcRotateAngle;
    }
}