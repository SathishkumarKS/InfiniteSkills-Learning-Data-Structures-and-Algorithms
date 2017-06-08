namespace DoubleStacks
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
            this.leftItemsListBox = new System.Windows.Forms.ListBox();
            this.popLeftButton = new System.Windows.Forms.Button();
            this.pushLeftButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.popRightButton = new System.Windows.Forms.Button();
            this.pushRightButton = new System.Windows.Forms.Button();
            this.rightItemsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // leftItemsListBox
            // 
            this.leftItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftItemsListBox.FormattingEnabled = true;
            this.leftItemsListBox.IntegralHeight = false;
            this.leftItemsListBox.Location = new System.Drawing.Point(137, 70);
            this.leftItemsListBox.MultiColumn = true;
            this.leftItemsListBox.Name = "leftItemsListBox";
            this.leftItemsListBox.Size = new System.Drawing.Size(75, 122);
            this.leftItemsListBox.TabIndex = 14;
            // 
            // popLeftButton
            // 
            this.popLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.popLeftButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.popLeftButton.Location = new System.Drawing.Point(137, 41);
            this.popLeftButton.Name = "popLeftButton";
            this.popLeftButton.Size = new System.Drawing.Size(75, 23);
            this.popLeftButton.TabIndex = 13;
            this.popLeftButton.Text = "Pop Left";
            this.popLeftButton.UseVisualStyleBackColor = true;
            this.popLeftButton.Click += new System.EventHandler(this.popLeftButton_Click);
            // 
            // pushLeftButton
            // 
            this.pushLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pushLeftButton.Location = new System.Drawing.Point(137, 12);
            this.pushLeftButton.Name = "pushLeftButton";
            this.pushLeftButton.Size = new System.Drawing.Size(75, 23);
            this.pushLeftButton.TabIndex = 12;
            this.pushLeftButton.Text = "Push Left";
            this.pushLeftButton.UseVisualStyleBackColor = true;
            this.pushLeftButton.Click += new System.EventHandler(this.pushLeftButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(55, 14);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(73, 20);
            this.valueTextBox.TabIndex = 11;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Value:";
            // 
            // popRightButton
            // 
            this.popRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.popRightButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.popRightButton.Location = new System.Drawing.Point(218, 41);
            this.popRightButton.Name = "popRightButton";
            this.popRightButton.Size = new System.Drawing.Size(75, 23);
            this.popRightButton.TabIndex = 16;
            this.popRightButton.Text = "Pop Right";
            this.popRightButton.UseVisualStyleBackColor = true;
            this.popRightButton.Click += new System.EventHandler(this.popRightButton_Click);
            // 
            // pushRightButton
            // 
            this.pushRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pushRightButton.Location = new System.Drawing.Point(218, 12);
            this.pushRightButton.Name = "pushRightButton";
            this.pushRightButton.Size = new System.Drawing.Size(75, 23);
            this.pushRightButton.TabIndex = 15;
            this.pushRightButton.Text = "Push Right";
            this.pushRightButton.UseVisualStyleBackColor = true;
            this.pushRightButton.Click += new System.EventHandler(this.pushRightButton_Click);
            // 
            // rightItemsListBox
            // 
            this.rightItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightItemsListBox.FormattingEnabled = true;
            this.rightItemsListBox.IntegralHeight = false;
            this.rightItemsListBox.Location = new System.Drawing.Point(218, 70);
            this.rightItemsListBox.MultiColumn = true;
            this.rightItemsListBox.Name = "rightItemsListBox";
            this.rightItemsListBox.Size = new System.Drawing.Size(75, 122);
            this.rightItemsListBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 204);
            this.Controls.Add(this.rightItemsListBox);
            this.Controls.Add(this.popRightButton);
            this.Controls.Add(this.pushRightButton);
            this.Controls.Add(this.leftItemsListBox);
            this.Controls.Add(this.popLeftButton);
            this.Controls.Add(this.pushLeftButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DoubleStacks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox leftItemsListBox;
        private System.Windows.Forms.Button popLeftButton;
        private System.Windows.Forms.Button pushLeftButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button popRightButton;
        private System.Windows.Forms.Button pushRightButton;
        private System.Windows.Forms.ListBox rightItemsListBox;
    }
}

