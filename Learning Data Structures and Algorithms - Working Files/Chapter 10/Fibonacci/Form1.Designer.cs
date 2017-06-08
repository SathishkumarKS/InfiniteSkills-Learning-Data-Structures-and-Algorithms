namespace Fibonacci
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
            this.recursiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recursiveResultTextBox = new System.Windows.Forms.TextBox();
            this.iterativeResultTextBox = new System.Windows.Forms.TextBox();
            this.iterativeTimeTextBox = new System.Windows.Forms.TextBox();
            this.iterativeButton = new System.Windows.Forms.Button();
            this.tableResultTextBox = new System.Windows.Forms.TextBox();
            this.tableTimeTextBox = new System.Windows.Forms.TextBox();
            this.tableButton = new System.Windows.Forms.Button();
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
            this.nTextBox.TabIndex = 0;
            this.nTextBox.Text = "35";
            this.nTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTextBox.TextChanged += new System.EventHandler(this.nTextBox_TextChanged);
            // 
            // recursiveButton
            // 
            this.recursiveButton.Location = new System.Drawing.Point(15, 83);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(75, 23);
            this.recursiveButton.TabIndex = 1;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = true;
            this.recursiveButton.Click += new System.EventHandler(this.recursiveButton_Click);
            // 
            // recursiveTimeTextBox
            // 
            this.recursiveTimeTextBox.Location = new System.Drawing.Point(244, 86);
            this.recursiveTimeTextBox.Name = "recursiveTimeTextBox";
            this.recursiveTimeTextBox.ReadOnly = true;
            this.recursiveTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.recursiveTimeTextBox.TabIndex = 3;
            this.recursiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Algorithm";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(244, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time (sec)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(106, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recursiveResultTextBox
            // 
            this.recursiveResultTextBox.Location = new System.Drawing.Point(106, 85);
            this.recursiveResultTextBox.Name = "recursiveResultTextBox";
            this.recursiveResultTextBox.ReadOnly = true;
            this.recursiveResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.recursiveResultTextBox.TabIndex = 2;
            this.recursiveResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iterativeResultTextBox
            // 
            this.iterativeResultTextBox.Location = new System.Drawing.Point(106, 137);
            this.iterativeResultTextBox.Name = "iterativeResultTextBox";
            this.iterativeResultTextBox.ReadOnly = true;
            this.iterativeResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.iterativeResultTextBox.TabIndex = 8;
            this.iterativeResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iterativeTimeTextBox
            // 
            this.iterativeTimeTextBox.Location = new System.Drawing.Point(244, 138);
            this.iterativeTimeTextBox.Name = "iterativeTimeTextBox";
            this.iterativeTimeTextBox.ReadOnly = true;
            this.iterativeTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.iterativeTimeTextBox.TabIndex = 9;
            this.iterativeTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iterativeButton
            // 
            this.iterativeButton.Location = new System.Drawing.Point(15, 135);
            this.iterativeButton.Name = "iterativeButton";
            this.iterativeButton.Size = new System.Drawing.Size(75, 23);
            this.iterativeButton.TabIndex = 7;
            this.iterativeButton.Text = "Iterative";
            this.iterativeButton.UseVisualStyleBackColor = true;
            this.iterativeButton.Click += new System.EventHandler(this.iterativeButton_Click);
            // 
            // tableResultTextBox
            // 
            this.tableResultTextBox.Location = new System.Drawing.Point(106, 111);
            this.tableResultTextBox.Name = "tableResultTextBox";
            this.tableResultTextBox.ReadOnly = true;
            this.tableResultTextBox.Size = new System.Drawing.Size(132, 20);
            this.tableResultTextBox.TabIndex = 5;
            this.tableResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableTimeTextBox
            // 
            this.tableTimeTextBox.Location = new System.Drawing.Point(244, 112);
            this.tableTimeTextBox.Name = "tableTimeTextBox";
            this.tableTimeTextBox.ReadOnly = true;
            this.tableTimeTextBox.Size = new System.Drawing.Size(132, 20);
            this.tableTimeTextBox.TabIndex = 6;
            this.tableTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableButton
            // 
            this.tableButton.Location = new System.Drawing.Point(15, 109);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(75, 23);
            this.tableButton.TabIndex = 4;
            this.tableButton.Text = "Table";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 170);
            this.Controls.Add(this.tableResultTextBox);
            this.Controls.Add(this.tableTimeTextBox);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.iterativeResultTextBox);
            this.Controls.Add(this.iterativeTimeTextBox);
            this.Controls.Add(this.iterativeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recursiveResultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recursiveTimeTextBox);
            this.Controls.Add(this.recursiveButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button recursiveButton;
        private System.Windows.Forms.TextBox recursiveTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recursiveResultTextBox;
        private System.Windows.Forms.TextBox iterativeResultTextBox;
        private System.Windows.Forms.TextBox iterativeTimeTextBox;
        private System.Windows.Forms.Button iterativeButton;
        private System.Windows.Forms.TextBox tableResultTextBox;
        private System.Windows.Forms.TextBox tableTimeTextBox;
        private System.Windows.Forms.Button tableButton;
    }
}

