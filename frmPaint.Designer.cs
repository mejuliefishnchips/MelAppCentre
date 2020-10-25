namespace MelindaFischerAssessment2
{
    partial class frmPaint
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.chkboxFillColor = new System.Windows.Forms.CheckBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnDrawForMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearCanvas = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(739, 570);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.BackColor = System.Drawing.Color.PeachPuff;
            this.btnColorPicker.Location = new System.Drawing.Point(757, 12);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(158, 33);
            this.btnColorPicker.TabIndex = 1;
            this.btnColorPicker.Text = "Color Picker";
            this.btnColorPicker.UseVisualStyleBackColor = false;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(760, 71);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(158, 69);
            this.trackBarSize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.Location = new System.Drawing.Point(757, 537);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Moccasin;
            this.btnPen.Location = new System.Drawing.Point(757, 146);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(157, 31);
            this.btnPen.TabIndex = 4;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRectangle.Location = new System.Drawing.Point(757, 220);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(158, 31);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCircle.Location = new System.Drawing.Point(757, 257);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(158, 31);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnTriangle.Location = new System.Drawing.Point(757, 294);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(158, 31);
            this.btnTriangle.TabIndex = 7;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // chkboxFillColor
            // 
            this.chkboxFillColor.AutoSize = true;
            this.chkboxFillColor.Location = new System.Drawing.Point(760, 116);
            this.chkboxFillColor.Name = "chkboxFillColor";
            this.chkboxFillColor.Size = new System.Drawing.Size(95, 24);
            this.chkboxFillColor.TabIndex = 8;
            this.chkboxFillColor.Text = "Fill Color";
            this.chkboxFillColor.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnLine.Location = new System.Drawing.Point(757, 183);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(158, 31);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnDrawForMe
            // 
            this.btnDrawForMe.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDrawForMe.Location = new System.Drawing.Point(757, 373);
            this.btnDrawForMe.Name = "btnDrawForMe";
            this.btnDrawForMe.Size = new System.Drawing.Size(157, 46);
            this.btnDrawForMe.TabIndex = 10;
            this.btnDrawForMe.Text = "Draw For Me";
            this.btnDrawForMe.UseVisualStyleBackColor = false;
            this.btnDrawForMe.Click += new System.EventHandler(this.btnDrawForMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(795, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pen Size";
            // 
            // btnClearCanvas
            // 
            this.btnClearCanvas.BackColor = System.Drawing.Color.PeachPuff;
            this.btnClearCanvas.Location = new System.Drawing.Point(756, 331);
            this.btnClearCanvas.Name = "btnClearCanvas";
            this.btnClearCanvas.Size = new System.Drawing.Size(158, 38);
            this.btnClearCanvas.TabIndex = 12;
            this.btnClearCanvas.Text = "Clear Canvas";
            this.btnClearCanvas.UseVisualStyleBackColor = false;
            this.btnClearCanvas.Click += new System.EventHandler(this.btnClearCanvas_Click);
            // 
            // lblFile
            // 
            this.lblFile.BackColor = System.Drawing.Color.Gold;
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFile.Location = new System.Drawing.Point(757, 424);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(157, 66);
            this.lblFile.TabIndex = 13;
            this.lblFile.Text = "Drag and Drop Image to set as Background";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 594);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnClearCanvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrawForMe);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.chkboxFillColor);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.canvas);
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.frmPaint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.CheckBox chkboxFillColor;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnDrawForMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearCanvas;
        private System.Windows.Forms.Label lblFile;
    }
}