namespace KnightsTour2
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
            this.numColsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numRowsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.positionsTriedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numColsTextBox
            // 
            this.numColsTextBox.Location = new System.Drawing.Point(206, 277);
            this.numColsTextBox.Name = "numColsTextBox";
            this.numColsTextBox.Size = new System.Drawing.Size(30, 20);
            this.numColsTextBox.TabIndex = 32;
            this.numColsTextBox.Text = "6";
            this.numColsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "# Cols:";
            // 
            // numRowsTextBox
            // 
            this.numRowsTextBox.Location = new System.Drawing.Point(101, 277);
            this.numRowsTextBox.Name = "numRowsTextBox";
            this.numRowsTextBox.Size = new System.Drawing.Size(30, 20);
            this.numRowsTextBox.TabIndex = 31;
            this.numRowsTextBox.Text = "6";
            this.numRowsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "# Rows:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(153, 358);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(64, 20);
            this.timeTextBox.TabIndex = 35;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Time:";
            // 
            // positionsTriedTextBox
            // 
            this.positionsTriedTextBox.Location = new System.Drawing.Point(153, 332);
            this.positionsTriedTextBox.Name = "positionsTriedTextBox";
            this.positionsTriedTextBox.ReadOnly = true;
            this.positionsTriedTextBox.Size = new System.Drawing.Size(64, 20);
            this.positionsTriedTextBox.TabIndex = 34;
            this.positionsTriedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Positions Tried:";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(105, 303);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 33;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // boardPictureBox
            // 
            this.boardPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPictureBox.Location = new System.Drawing.Point(12, 11);
            this.boardPictureBox.Name = "boardPictureBox";
            this.boardPictureBox.Size = new System.Drawing.Size(260, 260);
            this.boardPictureBox.TabIndex = 36;
            this.boardPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.solveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.numColsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numRowsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.positionsTriedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.boardPictureBox);
            this.Name = "Form1";
            this.Text = "KnightsTour2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numColsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numRowsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox positionsTriedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.PictureBox boardPictureBox;
    }
}

