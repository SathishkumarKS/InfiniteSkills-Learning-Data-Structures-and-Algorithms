namespace ArrayStack
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.popButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.IntegralHeight = false;
            this.itemsListBox.Location = new System.Drawing.Point(12, 70);
            this.itemsListBox.MultiColumn = true;
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(202, 122);
            this.itemsListBox.TabIndex = 9;
            // 
            // popButton
            // 
            this.popButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.popButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.popButton.Location = new System.Drawing.Point(139, 41);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(75, 23);
            this.popButton.TabIndex = 8;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pushButton.Location = new System.Drawing.Point(139, 12);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 7;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(55, 14);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(73, 20);
            this.valueTextBox.TabIndex = 6;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value:";
            // 
            // Form1
            // 
            this.AcceptButton = this.pushButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.popButton;
            this.ClientSize = new System.Drawing.Size(226, 204);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ArrayStack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label1;
    }
}

