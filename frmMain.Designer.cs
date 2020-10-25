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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOpenNumber = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 235);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(409, 66);
            this.btnPaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(90, 37);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnAdventureGame
            // 
            this.btnAdventureGame.Location = new System.Drawing.Point(409, 11);
            this.btnAdventureGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdventureGame.Name = "btnAdventureGame";
            this.btnAdventureGame.Size = new System.Drawing.Size(90, 51);
            this.btnAdventureGame.TabIndex = 2;
            this.btnAdventureGame.Text = "Adventure Game";
            this.btnAdventureGame.UseVisualStyleBackColor = true;
            this.btnAdventureGame.Click += new System.EventHandler(this.btnAdventureGame_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "dlgOpen";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(30, 38);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(120, 95);
            this.listBoxAnimals.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(409, 139);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 41);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open List of Animals";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOpenNumber
            // 
            this.btnOpenNumber.Location = new System.Drawing.Point(409, 186);
            this.btnOpenNumber.Name = "btnOpenNumber";
            this.btnOpenNumber.Size = new System.Drawing.Size(100, 41);
            this.btnOpenNumber.TabIndex = 5;
            this.btnOpenNumber.Text = "Open Number of Animals";
            this.btnOpenNumber.UseVisualStyleBackColor = true;
            this.btnOpenNumber.Click += new System.EventHandler(this.btnOpenNumber_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(184, 38);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(120, 95);
            this.listBoxNumbers.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnOpenNumber);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.btnAdventureGame);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnAdventureGame;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOpenNumber;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}

