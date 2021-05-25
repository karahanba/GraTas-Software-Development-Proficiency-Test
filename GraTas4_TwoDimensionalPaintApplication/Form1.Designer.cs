namespace GraTas4_TwoDimensionalPaintApplication
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnParallelEdge = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.lblCircumference);
            this.panel1.Controls.Add(this.lblLength);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnParallelEdge);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(117, 75);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(13, 17);
            this.lblArea.TabIndex = 20;
            this.lblArea.Text = "-";
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Location = new System.Drawing.Point(117, 44);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(13, 17);
            this.lblCircumference.TabIndex = 19;
            this.lblCircumference.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(117, 12);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(13, 17);
            this.lblLength.TabIndex = 18;
            this.lblLength.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Circumference:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Length:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1018, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1018, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 38);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.Black;
            this.btnEllipse.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.circle;
            this.btnEllipse.Location = new System.Drawing.Point(710, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(70, 80);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnParallelEdge
            // 
            this.btnParallelEdge.BackColor = System.Drawing.Color.Gainsboro;
            this.btnParallelEdge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnParallelEdge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnParallelEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParallelEdge.ForeColor = System.Drawing.Color.Black;
            this.btnParallelEdge.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.paralleledge;
            this.btnParallelEdge.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParallelEdge.Location = new System.Drawing.Point(938, 12);
            this.btnParallelEdge.Name = "btnParallelEdge";
            this.btnParallelEdge.Size = new System.Drawing.Size(70, 80);
            this.btnParallelEdge.TabIndex = 11;
            this.btnParallelEdge.Text = "Parallel Edge";
            this.btnParallelEdge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParallelEdge.UseVisualStyleBackColor = false;
            this.btnParallelEdge.Click += new System.EventHandler(this.btnParallelEdge_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.ForeColor = System.Drawing.Color.Black;
            this.btnSquare.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.square;
            this.btnSquare.Location = new System.Drawing.Point(786, 12);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(70, 80);
            this.btnSquare.TabIndex = 10;
            this.btnSquare.Text = "Square";
            this.btnSquare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.Black;
            this.btnRectangle.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(862, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(70, 80);
            this.btnRectangle.TabIndex = 9;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.ForeColor = System.Drawing.Color.Black;
            this.btnCircle.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.circle;
            this.btnCircle.Location = new System.Drawing.Point(634, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(70, 80);
            this.btnCircle.TabIndex = 8;
            this.btnCircle.Text = "Circle";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.Black;
            this.btnLine.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(558, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(70, 80);
            this.btnLine.TabIndex = 7;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.Black;
            this.btnEraser.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.eraser;
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEraser.Location = new System.Drawing.Point(406, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(70, 80);
            this.btnEraser.TabIndex = 6;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.Black;
            this.btnPencil.Image = global::GraTas4_TwoDimensionalPaintApplication.Properties.Resources.pencil;
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPencil.Location = new System.Drawing.Point(482, 12);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(70, 80);
            this.btnPencil.TabIndex = 5;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 689);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 14);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1176, 703);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDot.Location = new System.Drawing.Point(330, 12);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(70, 80);
            this.btnDot.TabIndex = 21;
            this.btnDot.Text = "( . ) Dot";
            this.btnDot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnParallelEdge;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDot;
    }
}

