namespace Permutations
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
            this.goButton = new System.Windows.Forms.Button();
            this.nNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.kNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.withDuplicatesLabel = new System.Windows.Forms.Label();
            this.withDuplicatesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.withoutDuplicatesLabel = new System.Windows.Forms.Label();
            this.withoutDuplicatesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(197, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 24;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // nNumericUpDown
            // 
            this.nNumericUpDown.Location = new System.Drawing.Point(125, 15);
            this.nNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumericUpDown.Name = "nNumericUpDown";
            this.nNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.nNumericUpDown.TabIndex = 23;
            this.nNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "of";
            // 
            // kNumericUpDown
            // 
            this.kNumericUpDown.Location = new System.Drawing.Point(58, 15);
            this.kNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kNumericUpDown.Name = "kNumericUpDown";
            this.kNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.kNumericUpDown.TabIndex = 22;
            this.kNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Select";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.withDuplicatesLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.withDuplicatesListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.withoutDuplicatesLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.withoutDuplicatesListBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 198);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "With Duplicates";
            // 
            // withDuplicatesLabel
            // 
            this.withDuplicatesLabel.AutoSize = true;
            this.withDuplicatesLabel.Location = new System.Drawing.Point(3, 178);
            this.withDuplicatesLabel.Name = "withDuplicatesLabel";
            this.withDuplicatesLabel.Size = new System.Drawing.Size(0, 13);
            this.withDuplicatesLabel.TabIndex = 2;
            // 
            // withDuplicatesListBox
            // 
            this.withDuplicatesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.withDuplicatesListBox.FormattingEnabled = true;
            this.withDuplicatesListBox.Location = new System.Drawing.Point(3, 23);
            this.withDuplicatesListBox.Name = "withDuplicatesListBox";
            this.withDuplicatesListBox.Size = new System.Drawing.Size(124, 147);
            this.withDuplicatesListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Without Duplicates";
            // 
            // withoutDuplicatesLabel
            // 
            this.withoutDuplicatesLabel.AutoSize = true;
            this.withoutDuplicatesLabel.Location = new System.Drawing.Point(133, 178);
            this.withoutDuplicatesLabel.Name = "withoutDuplicatesLabel";
            this.withoutDuplicatesLabel.Size = new System.Drawing.Size(0, 13);
            this.withoutDuplicatesLabel.TabIndex = 2;
            // 
            // withoutDuplicatesListBox
            // 
            this.withoutDuplicatesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.withoutDuplicatesListBox.FormattingEnabled = true;
            this.withoutDuplicatesListBox.Location = new System.Drawing.Point(133, 23);
            this.withoutDuplicatesListBox.Name = "withoutDuplicatesListBox";
            this.withoutDuplicatesListBox.Size = new System.Drawing.Size(124, 147);
            this.withoutDuplicatesListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.nNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Permutations";
            ((System.ComponentModel.ISupportInitialize)(this.nNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.NumericUpDown nNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown kNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label withDuplicatesLabel;
        private System.Windows.Forms.ListBox withDuplicatesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label withoutDuplicatesLabel;
        private System.Windows.Forms.ListBox withoutDuplicatesListBox;
    }
}

