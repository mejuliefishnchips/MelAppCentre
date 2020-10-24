namespace MelindaFischerAssessment2
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnAdventureGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(612, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(613, 249);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(135, 57);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnAdventureGame
            // 
            this.btnAdventureGame.Location = new System.Drawing.Point(323, 131);
            this.btnAdventureGame.Name = "btnAdventureGame";
            this.btnAdventureGame.Size = new System.Drawing.Size(240, 60);
            this.btnAdventureGame.TabIndex = 2;
            this.btnAdventureGame.Text = "Adventure Game";
            this.btnAdventureGame.UseVisualStyleBackColor = true;
            this.btnAdventureGame.Click += new System.EventHandler(this.btnAdventureGame_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdventureGame);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnExit);
            this.Name = "mainFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnAdventureGame;
    }
}

