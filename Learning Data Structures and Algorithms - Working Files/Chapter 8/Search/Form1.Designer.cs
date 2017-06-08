namespace Search
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
            this.interpolation2TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.interpolationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.maxTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxStepTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minStepTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.numItemsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // interpolation2TextBox
            // 
            this.interpolation2TextBox.Location = new System.Drawing.Point(97, 283);
            this.interpolation2TextBox.Name = "interpolation2TextBox";
            this.interpolation2TextBox.ReadOnly = true;
            this.interpolation2TextBox.Size = new System.Drawing.Size(74, 20);
            this.interpolation2TextBox.TabIndex = 27;
            this.interpolation2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Interpolation 2:";
            // 
            // interpolationTextBox
            // 
            this.interpolationTextBox.Location = new System.Drawing.Point(97, 257);
            this.interpolationTextBox.Name = "interpolationTextBox";
            this.interpolationTextBox.ReadOnly = true;
            this.interpolationTextBox.Size = new System.Drawing.Size(74, 20);
            this.interpolationTextBox.TabIndex = 21;
            this.interpolationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Interpolation:";
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(97, 231);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.Size = new System.Drawing.Size(74, 20);
            this.binaryTextBox.TabIndex = 20;
            this.binaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Binary:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(97, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Time (µs/run):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Algorithm";
            // 
            // linearTextBox
            // 
            this.linearTextBox.Location = new System.Drawing.Point(97, 205);
            this.linearTextBox.Name = "linearTextBox";
            this.linearTextBox.ReadOnly = true;
            this.linearTextBox.Size = new System.Drawing.Size(74, 20);
            this.linearTextBox.TabIndex = 18;
            this.linearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Linear:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(191, 122);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // maxTimeTextBox
            // 
            this.maxTimeTextBox.Location = new System.Drawing.Point(97, 124);
            this.maxTimeTextBox.Name = "maxTimeTextBox";
            this.maxTimeTextBox.Size = new System.Drawing.Size(74, 20);
            this.maxTimeTextBox.TabIndex = 16;
            this.maxTimeTextBox.Text = "0.25";
            this.maxTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Time/Alg (sec):";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maxStepTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minStepTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.numItemsTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // maxStepTextBox
            // 
            this.maxStepTextBox.Location = new System.Drawing.Point(85, 73);
            this.maxStepTextBox.Name = "maxStepTextBox";
            this.maxStepTextBox.Size = new System.Drawing.Size(74, 20);
            this.maxStepTextBox.TabIndex = 2;
            this.maxStepTextBox.Text = "5";
            this.maxStepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxStepTextBox.TextChanged += new System.EventHandler(this.parameter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Step:";
            // 
            // minStepTextBox
            // 
            this.minStepTextBox.Location = new System.Drawing.Point(85, 47);
            this.minStepTextBox.Name = "minStepTextBox";
            this.minStepTextBox.Size = new System.Drawing.Size(74, 20);
            this.minStepTextBox.TabIndex = 1;
            this.minStepTextBox.Text = "1";
            this.minStepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minStepTextBox.TextChanged += new System.EventHandler(this.parameter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Step:";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(179, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // numItemsTextBox
            // 
            this.numItemsTextBox.Location = new System.Drawing.Point(85, 21);
            this.numItemsTextBox.Name = "numItemsTextBox";
            this.numItemsTextBox.Size = new System.Drawing.Size(74, 20);
            this.numItemsTextBox.TabIndex = 0;
            this.numItemsTextBox.Text = "10000";
            this.numItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numItemsTextBox.TextChanged += new System.EventHandler(this.parameter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Items:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 315);
            this.Controls.Add(this.interpolation2TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.interpolationTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linearTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.maxTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox interpolation2TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox interpolationTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox linearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox maxTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxStepTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minStepTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox numItemsTextBox;
        private System.Windows.Forms.Label label1;
    }
}

