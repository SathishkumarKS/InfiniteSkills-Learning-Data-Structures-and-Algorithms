namespace EightQueens
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
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.positionsTriedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(153, 331);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(64, 20);
            this.timeTextBox.TabIndex = 11;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time:";
            // 
            // positionsTriedTextBox
            // 
            this.positionsTriedTextBox.Location = new System.Drawing.Point(153, 305);
            this.positionsTriedTextBox.Name = "positionsTriedTextBox";
            this.positionsTriedTextBox.ReadOnly = true;
            this.positionsTriedTextBox.Size = new System.Drawing.Size(64, 20);
            this.positionsTriedTextBox.TabIndex = 9;
            this.positionsTriedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Positions Tried:";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(105, 276);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 7;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // boardPictureBox
            // 
            this.boardPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPictureBox.Location = new System.Drawing.Point(12, 10);
            this.boardPictureBox.Name = "boardPictureBox";
            this.boardPictureBox.Size = new System.Drawing.Size(260, 260);
            this.boardPictureBox.TabIndex = 6;
            this.boardPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.solveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionsTriedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.boardPictureBox);
            this.Name = "Form1";
            this.Text = "EightQueens";
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox positionsTriedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.PictureBox boardPictureBox;
    }
}

