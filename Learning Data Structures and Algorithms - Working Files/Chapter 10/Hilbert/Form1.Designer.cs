namespace Hilbert
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
            this.hilbertPictureBox = new System.Windows.Forms.PictureBox();
            this.depthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hilbertPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hilbertPictureBox
            // 
            this.hilbertPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hilbertPictureBox.Location = new System.Drawing.Point(15, 43);
            this.hilbertPictureBox.Name = "hilbertPictureBox";
            this.hilbertPictureBox.Size = new System.Drawing.Size(257, 257);
            this.hilbertPictureBox.TabIndex = 18;
            this.hilbertPictureBox.TabStop = false;
            // 
            // depthNumericUpDown
            // 
            this.depthNumericUpDown.Location = new System.Drawing.Point(57, 16);
            this.depthNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.depthNumericUpDown.Name = "depthNumericUpDown";
            this.depthNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.depthNumericUpDown.TabIndex = 15;
            this.depthNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Location = new System.Drawing.Point(197, 13);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 16;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Depth:";
            // 
            // Form1
            // 
            this.AcceptButton = this.drawButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.hilbertPictureBox);
            this.Controls.Add(this.depthNumericUpDown);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hilbert";
            ((System.ComponentModel.ISupportInitialize)(this.hilbertPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hilbertPictureBox;
        private System.Windows.Forms.NumericUpDown depthNumericUpDown;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label1;
    }
}

