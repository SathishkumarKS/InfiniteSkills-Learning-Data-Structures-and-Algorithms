namespace AddSmaller
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
            this.label1 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.recursiveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recursiveResultTextBox = new System.Windows.Forms.TextBox();
            this.recursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nonrecursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.nonrecursiveResultTextBox = new System.Windows.Forms.TextBox();
            this.nonrecursiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(36, 12);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 1;
            this.nTextBox.Text = "10000";
            this.nTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTextBox.TextChanged += new System.EventHandler(this.nTextBox_TextChanged);
            // 
            // recursiveButton
            // 
            this.recursiveButton.Location = new System.Drawing.Point(12, 103);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(92, 23);
            this.recursiveButton.TabIndex = 2;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = true;
            this.recursiveButton.Click += new System.EventHandler(this.recursiveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Algorithm";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recursiveResultTextBox
            // 
            this.recursiveResultTextBox.Location = new System.Drawing.Point(110, 106);
            this.recursiveResultTextBox.Name = "recursiveResultTextBox";
            this.recursiveResultTextBox.ReadOnly = true;
            this.recursiveResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.recursiveResultTextBox.TabIndex = 5;
            this.recursiveResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // recursiveTimeTextBox
            // 
            this.recursiveTimeTextBox.Location = new System.Drawing.Point(248, 107);
            this.recursiveTimeTextBox.Name = "recursiveTimeTextBox";
            this.recursiveTimeTextBox.ReadOnly = true;
            this.recursiveTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.recursiveTimeTextBox.TabIndex = 7;
            this.recursiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(248, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time (sec)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nonrecursiveTimeTextBox
            // 
            this.nonrecursiveTimeTextBox.Location = new System.Drawing.Point(248, 133);
            this.nonrecursiveTimeTextBox.Name = "nonrecursiveTimeTextBox";
            this.nonrecursiveTimeTextBox.ReadOnly = true;
            this.nonrecursiveTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.nonrecursiveTimeTextBox.TabIndex = 10;
            this.nonrecursiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nonrecursiveResultTextBox
            // 
            this.nonrecursiveResultTextBox.Location = new System.Drawing.Point(110, 132);
            this.nonrecursiveResultTextBox.Name = "nonrecursiveResultTextBox";
            this.nonrecursiveResultTextBox.ReadOnly = true;
            this.nonrecursiveResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.nonrecursiveResultTextBox.TabIndex = 9;
            this.nonrecursiveResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nonrecursiveButton
            // 
            this.nonrecursiveButton.Location = new System.Drawing.Point(12, 129);
            this.nonrecursiveButton.Name = "nonrecursiveButton";
            this.nonrecursiveButton.Size = new System.Drawing.Size(92, 23);
            this.nonrecursiveButton.TabIndex = 8;
            this.nonrecursiveButton.Text = "Non-Recursive";
            this.nonrecursiveButton.UseVisualStyleBackColor = true;
            this.nonrecursiveButton.Click += new System.EventHandler(this.nonrecursiveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 165);
            this.Controls.Add(this.nonrecursiveTimeTextBox);
            this.Controls.Add(this.nonrecursiveResultTextBox);
            this.Controls.Add(this.nonrecursiveButton);
            this.Controls.Add(this.recursiveTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recursiveResultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recursiveButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AddSmaller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button recursiveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox recursiveResultTextBox;
        private System.Windows.Forms.TextBox recursiveTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nonrecursiveTimeTextBox;
        private System.Windows.Forms.TextBox nonrecursiveResultTextBox;
        private System.Windows.Forms.Button nonrecursiveButton;
    }
}

