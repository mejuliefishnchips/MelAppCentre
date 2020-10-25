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
            this.btnAvatar = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.btnLoadAnimals = new System.Windows.Forms.Button();
            this.btnOpenAmount = new System.Windows.Forms.Button();
            this.listBoxAmount = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(412, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.Location = new System.Drawing.Point(374, 111);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(176, 78);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.Location = new System.Drawing.Point(372, 26);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(177, 78);
            this.btnAvatar.TabIndex = 2;
            this.btnAvatar.Text = "Pick your Avatar";
            this.btnAvatar.UseVisualStyleBackColor = false;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "dlgOpen";
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.ItemHeight = 20;
            this.listBoxArray.Location = new System.Drawing.Point(18, 46);
            this.listBoxArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(142, 384);
            this.listBoxArray.TabIndex = 3;
            // 
            // btnLoadAnimals
            // 
            this.btnLoadAnimals.BackColor = System.Drawing.Color.Violet;
            this.btnLoadAnimals.Location = new System.Drawing.Point(376, 197);
            this.btnLoadAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadAnimals.Name = "btnLoadAnimals";
            this.btnLoadAnimals.Size = new System.Drawing.Size(174, 46);
            this.btnLoadAnimals.TabIndex = 4;
            this.btnLoadAnimals.Text = "Show me the animals";
            this.btnLoadAnimals.UseVisualStyleBackColor = false;
            this.btnLoadAnimals.Click += new System.EventHandler(this.btnLoadAnimals_Click);
            // 
            // btnOpenAmount
            // 
            this.btnOpenAmount.BackColor = System.Drawing.Color.Violet;
            this.btnOpenAmount.Location = new System.Drawing.Point(376, 253);
            this.btnOpenAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenAmount.Name = "btnOpenAmount";
            this.btnOpenAmount.Size = new System.Drawing.Size(173, 49);
            this.btnOpenAmount.TabIndex = 5;
            this.btnOpenAmount.Text = "Show me the amount of animals";
            this.btnOpenAmount.UseVisualStyleBackColor = false;
            this.btnOpenAmount.Click += new System.EventHandler(this.btnOpenAmount_Click);
            // 
            // listBoxAmount
            // 
            this.listBoxAmount.FormattingEnabled = true;
            this.listBoxAmount.ItemHeight = 20;
            this.listBoxAmount.Location = new System.Drawing.Point(168, 46);
            this.listBoxAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAmount.Name = "listBoxAmount";
            this.listBoxAmount.Size = new System.Drawing.Size(178, 384);
            this.listBoxAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "My animals:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount of animals i have:";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Plum;
            this.btnSort.Location = new System.Drawing.Point(376, 311);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(172, 48);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort for Me!";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(572, 449);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAmount);
            this.Controls.Add(this.btnOpenAmount);
            this.Controls.Add(this.btnLoadAnimals);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melinda\'s Little App Centre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.Button btnLoadAnimals;
        private System.Windows.Forms.Button btnOpenAmount;
        private System.Windows.Forms.ListBox listBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSort;
    }
}

