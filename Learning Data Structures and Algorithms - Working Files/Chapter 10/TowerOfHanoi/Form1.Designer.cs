namespace TowerOfHanoi
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.numDisksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDisksNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(15, 41);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(257, 211);
            this.resultTextBox.TabIndex = 7;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(109, 12);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 6;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // numDisksNumericUpDown
            // 
            this.numDisksNumericUpDown.Location = new System.Drawing.Point(64, 15);
            this.numDisksNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDisksNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDisksNumericUpDown.Name = "numDisksNumericUpDown";
            this.numDisksNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.numDisksNumericUpDown.TabIndex = 5;
            this.numDisksNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "# Disks:";
            // 
            // Form1
            // 
            this.AcceptButton = this.solveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.numDisksNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TowerOfHanoi";
            ((System.ComponentModel.ISupportInitialize)(this.numDisksNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.NumericUpDown numDisksNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}

