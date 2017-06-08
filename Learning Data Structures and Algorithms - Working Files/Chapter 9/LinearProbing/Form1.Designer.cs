namespace LinearProbing
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
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.fillPercentTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.longestTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createFindGroupBox = new System.Windows.Forms.GroupBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.loadTableGroupBox = new System.Windows.Forms.GroupBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numItemsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makeItemsButton = new System.Windows.Forms.Button();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticsGroupBox.SuspendLayout();
            this.createFindGroupBox.SuspendLayout();
            this.loadTableGroupBox.SuspendLayout();
            this.createGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.fillPercentTextBox);
            this.statisticsGroupBox.Controls.Add(this.label8);
            this.statisticsGroupBox.Controls.Add(this.averageTextBox);
            this.statisticsGroupBox.Controls.Add(this.longestTextBox);
            this.statisticsGroupBox.Controls.Add(this.label7);
            this.statisticsGroupBox.Controls.Add(this.label6);
            this.statisticsGroupBox.Enabled = false;
            this.statisticsGroupBox.Location = new System.Drawing.Point(14, 255);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(198, 104);
            this.statisticsGroupBox.TabIndex = 8;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // fillPercentTextBox
            // 
            this.fillPercentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillPercentTextBox.Location = new System.Drawing.Point(93, 22);
            this.fillPercentTextBox.Name = "fillPercentTextBox";
            this.fillPercentTextBox.ReadOnly = true;
            this.fillPercentTextBox.Size = new System.Drawing.Size(92, 20);
            this.fillPercentTextBox.TabIndex = 0;
            this.fillPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fill %";
            // 
            // averageTextBox
            // 
            this.averageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.averageTextBox.Location = new System.Drawing.Point(93, 74);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(92, 20);
            this.averageTextBox.TabIndex = 2;
            this.averageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // longestTextBox
            // 
            this.longestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longestTextBox.Location = new System.Drawing.Point(93, 48);
            this.longestTextBox.Name = "longestTextBox";
            this.longestTextBox.ReadOnly = true;
            this.longestTextBox.Size = new System.Drawing.Size(92, 20);
            this.longestTextBox.TabIndex = 1;
            this.longestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ave Probe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max Probe:";
            // 
            // createFindGroupBox
            // 
            this.createFindGroupBox.Controls.Add(this.insertButton);
            this.createFindGroupBox.Controls.Add(this.label3);
            this.createFindGroupBox.Controls.Add(this.itemTextBox);
            this.createFindGroupBox.Controls.Add(this.findButton);
            this.createFindGroupBox.Enabled = false;
            this.createFindGroupBox.Location = new System.Drawing.Point(14, 171);
            this.createFindGroupBox.Name = "createFindGroupBox";
            this.createFindGroupBox.Size = new System.Drawing.Size(198, 78);
            this.createFindGroupBox.TabIndex = 7;
            this.createFindGroupBox.TabStop = false;
            this.createFindGroupBox.Text = "Create/Find";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(110, 19);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(67, 34);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(37, 20);
            this.itemTextBox.TabIndex = 0;
            this.itemTextBox.Text = "123";
            this.itemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(110, 48);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // loadTableGroupBox
            // 
            this.loadTableGroupBox.Controls.Add(this.maxTextBox);
            this.loadTableGroupBox.Controls.Add(this.label5);
            this.loadTableGroupBox.Controls.Add(this.minTextBox);
            this.loadTableGroupBox.Controls.Add(this.label4);
            this.loadTableGroupBox.Controls.Add(this.numItemsTextBox);
            this.loadTableGroupBox.Controls.Add(this.label2);
            this.loadTableGroupBox.Controls.Add(this.makeItemsButton);
            this.loadTableGroupBox.Enabled = false;
            this.loadTableGroupBox.Location = new System.Drawing.Point(12, 66);
            this.loadTableGroupBox.Name = "loadTableGroupBox";
            this.loadTableGroupBox.Size = new System.Drawing.Size(200, 99);
            this.loadTableGroupBox.TabIndex = 6;
            this.loadTableGroupBox.TabStop = false;
            this.loadTableGroupBox.Text = "Load Table";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(69, 45);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(37, 20);
            this.maxTextBox.TabIndex = 1;
            this.maxTextBox.Text = "999";
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max:";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(69, 19);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(37, 20);
            this.minTextBox.TabIndex = 0;
            this.minTextBox.Text = "100";
            this.minTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min:";
            // 
            // numItemsTextBox
            // 
            this.numItemsTextBox.Location = new System.Drawing.Point(69, 71);
            this.numItemsTextBox.Name = "numItemsTextBox";
            this.numItemsTextBox.Size = new System.Drawing.Size(37, 20);
            this.numItemsTextBox.TabIndex = 2;
            this.numItemsTextBox.Text = "80";
            this.numItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Items:";
            // 
            // makeItemsButton
            // 
            this.makeItemsButton.Location = new System.Drawing.Point(112, 43);
            this.makeItemsButton.Name = "makeItemsButton";
            this.makeItemsButton.Size = new System.Drawing.Size(75, 23);
            this.makeItemsButton.TabIndex = 3;
            this.makeItemsButton.Text = "Make Items";
            this.makeItemsButton.UseVisualStyleBackColor = true;
            this.makeItemsButton.Click += new System.EventHandler(this.makeItemsButton_Click);
            // 
            // tableTextBox
            // 
            this.tableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tableTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTextBox.Location = new System.Drawing.Point(218, 12);
            this.tableTextBox.Multiline = true;
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.ReadOnly = true;
            this.tableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tableTextBox.Size = new System.Drawing.Size(384, 347);
            this.tableTextBox.TabIndex = 9;
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.createButton);
            this.createGroupBox.Controls.Add(this.sizeTextBox);
            this.createGroupBox.Controls.Add(this.label1);
            this.createGroupBox.Location = new System.Drawing.Point(12, 12);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Size = new System.Drawing.Size(200, 48);
            this.createGroupBox.TabIndex = 5;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "Hash Table";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(112, 18);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(69, 21);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(37, 20);
            this.sizeTextBox.TabIndex = 0;
            this.sizeTextBox.Text = "101";
            this.sizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // Form1
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.createFindGroupBox);
            this.Controls.Add(this.loadTableGroupBox);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.createGroupBox);
            this.Name = "Form1";
            this.Text = "LinearProbing";
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.createFindGroupBox.ResumeLayout(false);
            this.createFindGroupBox.PerformLayout();
            this.loadTableGroupBox.ResumeLayout(false);
            this.loadTableGroupBox.PerformLayout();
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.TextBox fillPercentTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.TextBox longestTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox createFindGroupBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox loadTableGroupBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numItemsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button makeItemsButton;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.GroupBox createGroupBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label label1;
    }
}

