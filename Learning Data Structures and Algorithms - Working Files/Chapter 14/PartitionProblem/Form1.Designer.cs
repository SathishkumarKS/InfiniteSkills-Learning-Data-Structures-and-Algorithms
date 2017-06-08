namespace PartitionProblem
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
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.set0ListBox = new System.Windows.Forms.ListBox();
            this.set1ListBox = new System.Windows.Forms.ListBox();
            this.exhaustiveButton = new System.Windows.Forms.Button();
            this.branchAndBoundButton = new System.Windows.Forms.Button();
            this.randWithSwapsButton = new System.Windows.Forms.Button();
            this.makeValuesButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numValuesTextBox = new System.Windows.Forms.TextBox();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exhaustiveTimeTextBox = new System.Windows.Forms.TextBox();
            this.branchAndBoundTimeTextBox = new System.Windows.Forms.TextBox();
            this.randWithSwapsTimeTextBox = new System.Windows.Forms.TextBox();
            this.randWithSwapsDiffTextBox = new System.Windows.Forms.TextBox();
            this.branchAndBoundDiffTextBox = new System.Windows.Forms.TextBox();
            this.exhaustiveDiffTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.total1TextBox = new System.Windows.Forms.TextBox();
            this.total0TextBox = new System.Windows.Forms.TextBox();
            this.greedyDiffTextBox = new System.Windows.Forms.TextBox();
            this.greedyTimeTextBox = new System.Windows.Forms.TextBox();
            this.greedyButton = new System.Windows.Forms.Button();
            this.sortedGreedyDiffTextBox = new System.Windows.Forms.TextBox();
            this.sortedGreedyTimeTextBox = new System.Windows.Forms.TextBox();
            this.sortedGreedyButton = new System.Windows.Forms.Button();
            this.randomDiffTextBox = new System.Windows.Forms.TextBox();
            this.randomTimeTextBox = new System.Windows.Forms.TextBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valuesListBox
            // 
            this.valuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.IntegralHeight = false;
            this.valuesListBox.Location = new System.Drawing.Point(12, 226);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(109, 132);
            this.valuesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Values";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // set0ListBox
            // 
            this.set0ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.set0ListBox.FormattingEnabled = true;
            this.set0ListBox.IntegralHeight = false;
            this.set0ListBox.Location = new System.Drawing.Point(276, 226);
            this.set0ListBox.Name = "set0ListBox";
            this.set0ListBox.Size = new System.Drawing.Size(109, 132);
            this.set0ListBox.TabIndex = 2;
            // 
            // set1ListBox
            // 
            this.set1ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.set1ListBox.FormattingEnabled = true;
            this.set1ListBox.IntegralHeight = false;
            this.set1ListBox.Location = new System.Drawing.Point(391, 226);
            this.set1ListBox.Name = "set1ListBox";
            this.set1ListBox.Size = new System.Drawing.Size(109, 132);
            this.set1ListBox.TabIndex = 4;
            // 
            // exhaustiveButton
            // 
            this.exhaustiveButton.Enabled = false;
            this.exhaustiveButton.Location = new System.Drawing.Point(158, 31);
            this.exhaustiveButton.Name = "exhaustiveButton";
            this.exhaustiveButton.Size = new System.Drawing.Size(109, 23);
            this.exhaustiveButton.TabIndex = 6;
            this.exhaustiveButton.Text = "Exhaustive";
            this.exhaustiveButton.UseVisualStyleBackColor = true;
            this.exhaustiveButton.Click += new System.EventHandler(this.exhaustiveButton_Click);
            // 
            // branchAndBoundButton
            // 
            this.branchAndBoundButton.Enabled = false;
            this.branchAndBoundButton.Location = new System.Drawing.Point(158, 60);
            this.branchAndBoundButton.Name = "branchAndBoundButton";
            this.branchAndBoundButton.Size = new System.Drawing.Size(109, 23);
            this.branchAndBoundButton.TabIndex = 7;
            this.branchAndBoundButton.Text = "Branch && Bound";
            this.branchAndBoundButton.UseVisualStyleBackColor = true;
            this.branchAndBoundButton.Click += new System.EventHandler(this.branchAndBoundButton_Click);
            // 
            // randWithSwapsButton
            // 
            this.randWithSwapsButton.Enabled = false;
            this.randWithSwapsButton.Location = new System.Drawing.Point(158, 111);
            this.randWithSwapsButton.Name = "randWithSwapsButton";
            this.randWithSwapsButton.Size = new System.Drawing.Size(109, 23);
            this.randWithSwapsButton.TabIndex = 8;
            this.randWithSwapsButton.Text = "Random w/Swaps";
            this.randWithSwapsButton.UseVisualStyleBackColor = true;
            this.randWithSwapsButton.Click += new System.EventHandler(this.randWithSwapsButton_Click);
            // 
            // makeValuesButton
            // 
            this.makeValuesButton.Location = new System.Drawing.Point(12, 90);
            this.makeValuesButton.Name = "makeValuesButton";
            this.makeValuesButton.Size = new System.Drawing.Size(109, 23);
            this.makeValuesButton.TabIndex = 9;
            this.makeValuesButton.Text = "Make Values";
            this.makeValuesButton.UseVisualStyleBackColor = true;
            this.makeValuesButton.Click += new System.EventHandler(this.makeValuesButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "# Values:";
            // 
            // numValuesTextBox
            // 
            this.numValuesTextBox.Location = new System.Drawing.Point(72, 12);
            this.numValuesTextBox.Name = "numValuesTextBox";
            this.numValuesTextBox.Size = new System.Drawing.Size(49, 20);
            this.numValuesTextBox.TabIndex = 11;
            this.numValuesTextBox.Text = "20";
            this.numValuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numValuesTextBox.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(72, 38);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(49, 20);
            this.minimumTextBox.TabIndex = 13;
            this.minimumTextBox.Text = "10";
            this.minimumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minimumTextBox.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minimum:";
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(72, 64);
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.Size = new System.Drawing.Size(49, 20);
            this.maximumTextBox.TabIndex = 15;
            this.maximumTextBox.Text = "50";
            this.maximumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maximumTextBox.TextChanged += new System.EventHandler(this.parameters_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maximum:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(276, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time (sec)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exhaustiveTimeTextBox
            // 
            this.exhaustiveTimeTextBox.Location = new System.Drawing.Point(276, 33);
            this.exhaustiveTimeTextBox.Name = "exhaustiveTimeTextBox";
            this.exhaustiveTimeTextBox.ReadOnly = true;
            this.exhaustiveTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.exhaustiveTimeTextBox.TabIndex = 17;
            this.exhaustiveTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // branchAndBoundTimeTextBox
            // 
            this.branchAndBoundTimeTextBox.Location = new System.Drawing.Point(276, 62);
            this.branchAndBoundTimeTextBox.Name = "branchAndBoundTimeTextBox";
            this.branchAndBoundTimeTextBox.ReadOnly = true;
            this.branchAndBoundTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.branchAndBoundTimeTextBox.TabIndex = 18;
            this.branchAndBoundTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // randWithSwapsTimeTextBox
            // 
            this.randWithSwapsTimeTextBox.Location = new System.Drawing.Point(276, 114);
            this.randWithSwapsTimeTextBox.Name = "randWithSwapsTimeTextBox";
            this.randWithSwapsTimeTextBox.ReadOnly = true;
            this.randWithSwapsTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.randWithSwapsTimeTextBox.TabIndex = 19;
            this.randWithSwapsTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // randWithSwapsDiffTextBox
            // 
            this.randWithSwapsDiffTextBox.Location = new System.Drawing.Point(391, 115);
            this.randWithSwapsDiffTextBox.Name = "randWithSwapsDiffTextBox";
            this.randWithSwapsDiffTextBox.ReadOnly = true;
            this.randWithSwapsDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.randWithSwapsDiffTextBox.TabIndex = 23;
            this.randWithSwapsDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // branchAndBoundDiffTextBox
            // 
            this.branchAndBoundDiffTextBox.Location = new System.Drawing.Point(391, 63);
            this.branchAndBoundDiffTextBox.Name = "branchAndBoundDiffTextBox";
            this.branchAndBoundDiffTextBox.ReadOnly = true;
            this.branchAndBoundDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.branchAndBoundDiffTextBox.TabIndex = 22;
            this.branchAndBoundDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exhaustiveDiffTextBox
            // 
            this.exhaustiveDiffTextBox.Location = new System.Drawing.Point(391, 34);
            this.exhaustiveDiffTextBox.Name = "exhaustiveDiffTextBox";
            this.exhaustiveDiffTextBox.ReadOnly = true;
            this.exhaustiveDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.exhaustiveDiffTextBox.TabIndex = 21;
            this.exhaustiveDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(391, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Difference";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total1TextBox
            // 
            this.total1TextBox.Location = new System.Drawing.Point(391, 202);
            this.total1TextBox.Name = "total1TextBox";
            this.total1TextBox.ReadOnly = true;
            this.total1TextBox.Size = new System.Drawing.Size(109, 20);
            this.total1TextBox.TabIndex = 25;
            this.total1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total0TextBox
            // 
            this.total0TextBox.Location = new System.Drawing.Point(276, 201);
            this.total0TextBox.Name = "total0TextBox";
            this.total0TextBox.ReadOnly = true;
            this.total0TextBox.Size = new System.Drawing.Size(109, 20);
            this.total0TextBox.TabIndex = 24;
            this.total0TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greedyDiffTextBox
            // 
            this.greedyDiffTextBox.Location = new System.Drawing.Point(391, 141);
            this.greedyDiffTextBox.Name = "greedyDiffTextBox";
            this.greedyDiffTextBox.ReadOnly = true;
            this.greedyDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.greedyDiffTextBox.TabIndex = 28;
            this.greedyDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // greedyTimeTextBox
            // 
            this.greedyTimeTextBox.Location = new System.Drawing.Point(276, 140);
            this.greedyTimeTextBox.Name = "greedyTimeTextBox";
            this.greedyTimeTextBox.ReadOnly = true;
            this.greedyTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.greedyTimeTextBox.TabIndex = 27;
            this.greedyTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // greedyButton
            // 
            this.greedyButton.Enabled = false;
            this.greedyButton.Location = new System.Drawing.Point(158, 137);
            this.greedyButton.Name = "greedyButton";
            this.greedyButton.Size = new System.Drawing.Size(109, 23);
            this.greedyButton.TabIndex = 26;
            this.greedyButton.Text = "Greedy";
            this.greedyButton.UseVisualStyleBackColor = true;
            this.greedyButton.Click += new System.EventHandler(this.greedyButton_Click);
            // 
            // sortedGreedyDiffTextBox
            // 
            this.sortedGreedyDiffTextBox.Location = new System.Drawing.Point(391, 167);
            this.sortedGreedyDiffTextBox.Name = "sortedGreedyDiffTextBox";
            this.sortedGreedyDiffTextBox.ReadOnly = true;
            this.sortedGreedyDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.sortedGreedyDiffTextBox.TabIndex = 31;
            this.sortedGreedyDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sortedGreedyTimeTextBox
            // 
            this.sortedGreedyTimeTextBox.Location = new System.Drawing.Point(276, 166);
            this.sortedGreedyTimeTextBox.Name = "sortedGreedyTimeTextBox";
            this.sortedGreedyTimeTextBox.ReadOnly = true;
            this.sortedGreedyTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.sortedGreedyTimeTextBox.TabIndex = 30;
            this.sortedGreedyTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sortedGreedyButton
            // 
            this.sortedGreedyButton.Enabled = false;
            this.sortedGreedyButton.Location = new System.Drawing.Point(158, 163);
            this.sortedGreedyButton.Name = "sortedGreedyButton";
            this.sortedGreedyButton.Size = new System.Drawing.Size(109, 23);
            this.sortedGreedyButton.TabIndex = 29;
            this.sortedGreedyButton.Text = "Sorted Greedy";
            this.sortedGreedyButton.UseVisualStyleBackColor = true;
            this.sortedGreedyButton.Click += new System.EventHandler(this.sortedGreedyButton_Click);
            // 
            // randomDiffTextBox
            // 
            this.randomDiffTextBox.Location = new System.Drawing.Point(391, 89);
            this.randomDiffTextBox.Name = "randomDiffTextBox";
            this.randomDiffTextBox.ReadOnly = true;
            this.randomDiffTextBox.Size = new System.Drawing.Size(109, 20);
            this.randomDiffTextBox.TabIndex = 34;
            this.randomDiffTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // randomTimeTextBox
            // 
            this.randomTimeTextBox.Location = new System.Drawing.Point(276, 88);
            this.randomTimeTextBox.Name = "randomTimeTextBox";
            this.randomTimeTextBox.ReadOnly = true;
            this.randomTimeTextBox.Size = new System.Drawing.Size(109, 20);
            this.randomTimeTextBox.TabIndex = 33;
            this.randomTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // randomButton
            // 
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(158, 86);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(109, 23);
            this.randomButton.TabIndex = 32;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 370);
            this.Controls.Add(this.randomDiffTextBox);
            this.Controls.Add(this.randomTimeTextBox);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.sortedGreedyDiffTextBox);
            this.Controls.Add(this.sortedGreedyTimeTextBox);
            this.Controls.Add(this.sortedGreedyButton);
            this.Controls.Add(this.greedyDiffTextBox);
            this.Controls.Add(this.greedyTimeTextBox);
            this.Controls.Add(this.greedyButton);
            this.Controls.Add(this.total1TextBox);
            this.Controls.Add(this.total0TextBox);
            this.Controls.Add(this.randWithSwapsDiffTextBox);
            this.Controls.Add(this.branchAndBoundDiffTextBox);
            this.Controls.Add(this.exhaustiveDiffTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.randWithSwapsTimeTextBox);
            this.Controls.Add(this.branchAndBoundTimeTextBox);
            this.Controls.Add(this.exhaustiveTimeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maximumTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minimumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numValuesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.makeValuesButton);
            this.Controls.Add(this.randWithSwapsButton);
            this.Controls.Add(this.branchAndBoundButton);
            this.Controls.Add(this.exhaustiveButton);
            this.Controls.Add(this.set1ListBox);
            this.Controls.Add(this.set0ListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valuesListBox);
            this.Name = "Form1";
            this.Text = "PartitionProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox set0ListBox;
        private System.Windows.Forms.ListBox set1ListBox;
        private System.Windows.Forms.Button exhaustiveButton;
        private System.Windows.Forms.Button branchAndBoundButton;
        private System.Windows.Forms.Button randWithSwapsButton;
        private System.Windows.Forms.Button makeValuesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numValuesTextBox;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox exhaustiveTimeTextBox;
        private System.Windows.Forms.TextBox branchAndBoundTimeTextBox;
        private System.Windows.Forms.TextBox randWithSwapsTimeTextBox;
        private System.Windows.Forms.TextBox randWithSwapsDiffTextBox;
        private System.Windows.Forms.TextBox branchAndBoundDiffTextBox;
        private System.Windows.Forms.TextBox exhaustiveDiffTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total1TextBox;
        private System.Windows.Forms.TextBox total0TextBox;
        private System.Windows.Forms.TextBox greedyDiffTextBox;
        private System.Windows.Forms.TextBox greedyTimeTextBox;
        private System.Windows.Forms.Button greedyButton;
        private System.Windows.Forms.TextBox sortedGreedyDiffTextBox;
        private System.Windows.Forms.TextBox sortedGreedyTimeTextBox;
        private System.Windows.Forms.Button sortedGreedyButton;
        private System.Windows.Forms.TextBox randomDiffTextBox;
        private System.Windows.Forms.TextBox randomTimeTextBox;
        private System.Windows.Forms.Button randomButton;
    }
}

