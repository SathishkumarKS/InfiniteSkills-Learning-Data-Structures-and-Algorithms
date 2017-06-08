namespace Sorting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUnsortedCheckBox = new System.Windows.Forms.CheckBox();
            this.numUnsortedTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numValuesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countingsortTextBox = new System.Windows.Forms.TextBox();
            this.countingsortCheckBox = new System.Windows.Forms.CheckBox();
            this.mergesort2TextBox = new System.Windows.Forms.TextBox();
            this.mergesort2CheckBox = new System.Windows.Forms.CheckBox();
            this.mergesortTextBox = new System.Windows.Forms.TextBox();
            this.mergesortCheckBox = new System.Windows.Forms.CheckBox();
            this.heapsortTextBox = new System.Windows.Forms.TextBox();
            this.heapsortCheckBox = new System.Windows.Forms.CheckBox();
            this.insertionsortTextBox = new System.Windows.Forms.TextBox();
            this.insertionsortCheckBox = new System.Windows.Forms.CheckBox();
            this.selectionsortTextBox = new System.Windows.Forms.TextBox();
            this.selectionsortCheckBox = new System.Windows.Forms.CheckBox();
            this.bubblesort2TextBox = new System.Windows.Forms.TextBox();
            this.bubblesort2CheckBox = new System.Windows.Forms.CheckBox();
            this.bubblesortTextBox = new System.Windows.Forms.TextBox();
            this.bubblesortCheckBox = new System.Windows.Forms.CheckBox();
            this.quicksortTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.secsPerAlgTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.quicksortCheckBox = new System.Windows.Forms.CheckBox();
            this.unsortedListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUnsortedCheckBox);
            this.groupBox1.Controls.Add(this.numUnsortedTextBox);
            this.groupBox1.Controls.Add(this.generateButton);
            this.groupBox1.Controls.Add(this.maximumTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.minimumTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numValuesTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Values";
            // 
            // numUnsortedCheckBox
            // 
            this.numUnsortedCheckBox.AutoSize = true;
            this.numUnsortedCheckBox.Location = new System.Drawing.Point(25, 97);
            this.numUnsortedCheckBox.Name = "numUnsortedCheckBox";
            this.numUnsortedCheckBox.Size = new System.Drawing.Size(82, 17);
            this.numUnsortedCheckBox.TabIndex = 3;
            this.numUnsortedCheckBox.Text = "# Unsorted:";
            this.numUnsortedCheckBox.UseVisualStyleBackColor = true;
            this.numUnsortedCheckBox.CheckedChanged += new System.EventHandler(this.numUnsortedCheckBox_CheckedChanged);
            // 
            // numUnsortedTextBox
            // 
            this.numUnsortedTextBox.Enabled = false;
            this.numUnsortedTextBox.Location = new System.Drawing.Point(82, 120);
            this.numUnsortedTextBox.Name = "numUnsortedTextBox";
            this.numUnsortedTextBox.Size = new System.Drawing.Size(77, 20);
            this.numUnsortedTextBox.TabIndex = 4;
            this.numUnsortedTextBox.Text = "10";
            this.numUnsortedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUnsortedTextBox.TextChanged += new System.EventHandler(this.parameterTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(179, 43);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(82, 71);
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.Size = new System.Drawing.Size(77, 20);
            this.maximumTextBox.TabIndex = 2;
            this.maximumTextBox.Text = "99";
            this.maximumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maximumTextBox.TextChanged += new System.EventHandler(this.parameterTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum:";
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(82, 45);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(77, 20);
            this.minimumTextBox.TabIndex = 1;
            this.minimumTextBox.Text = "0";
            this.minimumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minimumTextBox.TextChanged += new System.EventHandler(this.parameterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum:";
            // 
            // numValuesTextBox
            // 
            this.numValuesTextBox.Location = new System.Drawing.Point(82, 19);
            this.numValuesTextBox.Name = "numValuesTextBox";
            this.numValuesTextBox.Size = new System.Drawing.Size(77, 20);
            this.numValuesTextBox.TabIndex = 0;
            this.numValuesTextBox.Text = "10";
            this.numValuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numValuesTextBox.TextChanged += new System.EventHandler(this.parameterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Values:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.countingsortTextBox);
            this.groupBox2.Controls.Add(this.countingsortCheckBox);
            this.groupBox2.Controls.Add(this.mergesort2TextBox);
            this.groupBox2.Controls.Add(this.mergesort2CheckBox);
            this.groupBox2.Controls.Add(this.mergesortTextBox);
            this.groupBox2.Controls.Add(this.mergesortCheckBox);
            this.groupBox2.Controls.Add(this.heapsortTextBox);
            this.groupBox2.Controls.Add(this.heapsortCheckBox);
            this.groupBox2.Controls.Add(this.insertionsortTextBox);
            this.groupBox2.Controls.Add(this.insertionsortCheckBox);
            this.groupBox2.Controls.Add(this.selectionsortTextBox);
            this.groupBox2.Controls.Add(this.selectionsortCheckBox);
            this.groupBox2.Controls.Add(this.bubblesort2TextBox);
            this.groupBox2.Controls.Add(this.bubblesort2CheckBox);
            this.groupBox2.Controls.Add(this.bubblesortTextBox);
            this.groupBox2.Controls.Add(this.bubblesortCheckBox);
            this.groupBox2.Controls.Add(this.quicksortTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.secsPerAlgTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.runButton);
            this.groupBox2.Controls.Add(this.quicksortCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithms";
            // 
            // countingsortTextBox
            // 
            this.countingsortTextBox.Location = new System.Drawing.Point(177, 293);
            this.countingsortTextBox.Name = "countingsortTextBox";
            this.countingsortTextBox.ReadOnly = true;
            this.countingsortTextBox.Size = new System.Drawing.Size(77, 20);
            this.countingsortTextBox.TabIndex = 27;
            this.countingsortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // countingsortCheckBox
            // 
            this.countingsortCheckBox.AutoSize = true;
            this.countingsortCheckBox.Checked = true;
            this.countingsortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countingsortCheckBox.Location = new System.Drawing.Point(25, 295);
            this.countingsortCheckBox.Name = "countingsortCheckBox";
            this.countingsortCheckBox.Size = new System.Drawing.Size(85, 17);
            this.countingsortCheckBox.TabIndex = 26;
            this.countingsortCheckBox.Text = "Countingsort";
            this.countingsortCheckBox.UseVisualStyleBackColor = true;
            // 
            // mergesort2TextBox
            // 
            this.mergesort2TextBox.Location = new System.Drawing.Point(177, 215);
            this.mergesort2TextBox.Name = "mergesort2TextBox";
            this.mergesort2TextBox.ReadOnly = true;
            this.mergesort2TextBox.Size = new System.Drawing.Size(77, 20);
            this.mergesort2TextBox.TabIndex = 25;
            this.mergesort2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mergesort2CheckBox
            // 
            this.mergesort2CheckBox.AutoSize = true;
            this.mergesort2CheckBox.Checked = true;
            this.mergesort2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergesort2CheckBox.Location = new System.Drawing.Point(25, 217);
            this.mergesort2CheckBox.Name = "mergesort2CheckBox";
            this.mergesort2CheckBox.Size = new System.Drawing.Size(79, 17);
            this.mergesort2CheckBox.TabIndex = 24;
            this.mergesort2CheckBox.Text = "Mergesort2";
            this.mergesort2CheckBox.UseVisualStyleBackColor = true;
            // 
            // mergesortTextBox
            // 
            this.mergesortTextBox.Location = new System.Drawing.Point(177, 189);
            this.mergesortTextBox.Name = "mergesortTextBox";
            this.mergesortTextBox.ReadOnly = true;
            this.mergesortTextBox.Size = new System.Drawing.Size(77, 20);
            this.mergesortTextBox.TabIndex = 23;
            this.mergesortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mergesortCheckBox
            // 
            this.mergesortCheckBox.AutoSize = true;
            this.mergesortCheckBox.Checked = true;
            this.mergesortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergesortCheckBox.Location = new System.Drawing.Point(25, 191);
            this.mergesortCheckBox.Name = "mergesortCheckBox";
            this.mergesortCheckBox.Size = new System.Drawing.Size(73, 17);
            this.mergesortCheckBox.TabIndex = 22;
            this.mergesortCheckBox.Text = "Mergesort";
            this.mergesortCheckBox.UseVisualStyleBackColor = true;
            // 
            // heapsortTextBox
            // 
            this.heapsortTextBox.Location = new System.Drawing.Point(177, 163);
            this.heapsortTextBox.Name = "heapsortTextBox";
            this.heapsortTextBox.ReadOnly = true;
            this.heapsortTextBox.Size = new System.Drawing.Size(77, 20);
            this.heapsortTextBox.TabIndex = 21;
            this.heapsortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // heapsortCheckBox
            // 
            this.heapsortCheckBox.AutoSize = true;
            this.heapsortCheckBox.Checked = true;
            this.heapsortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.heapsortCheckBox.Location = new System.Drawing.Point(25, 165);
            this.heapsortCheckBox.Name = "heapsortCheckBox";
            this.heapsortCheckBox.Size = new System.Drawing.Size(69, 17);
            this.heapsortCheckBox.TabIndex = 20;
            this.heapsortCheckBox.Text = "Heapsort";
            this.heapsortCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertionsortTextBox
            // 
            this.insertionsortTextBox.Location = new System.Drawing.Point(177, 85);
            this.insertionsortTextBox.Name = "insertionsortTextBox";
            this.insertionsortTextBox.ReadOnly = true;
            this.insertionsortTextBox.Size = new System.Drawing.Size(77, 20);
            this.insertionsortTextBox.TabIndex = 19;
            this.insertionsortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insertionsortCheckBox
            // 
            this.insertionsortCheckBox.AutoSize = true;
            this.insertionsortCheckBox.Checked = true;
            this.insertionsortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.insertionsortCheckBox.Location = new System.Drawing.Point(25, 87);
            this.insertionsortCheckBox.Name = "insertionsortCheckBox";
            this.insertionsortCheckBox.Size = new System.Drawing.Size(83, 17);
            this.insertionsortCheckBox.TabIndex = 18;
            this.insertionsortCheckBox.Text = "Insertionsort";
            this.insertionsortCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectionsortTextBox
            // 
            this.selectionsortTextBox.Location = new System.Drawing.Point(177, 111);
            this.selectionsortTextBox.Name = "selectionsortTextBox";
            this.selectionsortTextBox.ReadOnly = true;
            this.selectionsortTextBox.Size = new System.Drawing.Size(77, 20);
            this.selectionsortTextBox.TabIndex = 17;
            this.selectionsortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // selectionsortCheckBox
            // 
            this.selectionsortCheckBox.AutoSize = true;
            this.selectionsortCheckBox.Checked = true;
            this.selectionsortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectionsortCheckBox.Location = new System.Drawing.Point(25, 113);
            this.selectionsortCheckBox.Name = "selectionsortCheckBox";
            this.selectionsortCheckBox.Size = new System.Drawing.Size(87, 17);
            this.selectionsortCheckBox.TabIndex = 16;
            this.selectionsortCheckBox.Text = "Selectionsort";
            this.selectionsortCheckBox.UseVisualStyleBackColor = true;
            // 
            // bubblesort2TextBox
            // 
            this.bubblesort2TextBox.Location = new System.Drawing.Point(177, 267);
            this.bubblesort2TextBox.Name = "bubblesort2TextBox";
            this.bubblesort2TextBox.ReadOnly = true;
            this.bubblesort2TextBox.Size = new System.Drawing.Size(77, 20);
            this.bubblesort2TextBox.TabIndex = 15;
            this.bubblesort2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bubblesort2CheckBox
            // 
            this.bubblesort2CheckBox.AutoSize = true;
            this.bubblesort2CheckBox.Checked = true;
            this.bubblesort2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bubblesort2CheckBox.Location = new System.Drawing.Point(25, 269);
            this.bubblesort2CheckBox.Name = "bubblesort2CheckBox";
            this.bubblesort2CheckBox.Size = new System.Drawing.Size(82, 17);
            this.bubblesort2CheckBox.TabIndex = 14;
            this.bubblesort2CheckBox.Text = "Bubblesort2";
            this.bubblesort2CheckBox.UseVisualStyleBackColor = true;
            // 
            // bubblesortTextBox
            // 
            this.bubblesortTextBox.Location = new System.Drawing.Point(177, 241);
            this.bubblesortTextBox.Name = "bubblesortTextBox";
            this.bubblesortTextBox.ReadOnly = true;
            this.bubblesortTextBox.Size = new System.Drawing.Size(77, 20);
            this.bubblesortTextBox.TabIndex = 13;
            this.bubblesortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bubblesortCheckBox
            // 
            this.bubblesortCheckBox.AutoSize = true;
            this.bubblesortCheckBox.Checked = true;
            this.bubblesortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bubblesortCheckBox.Location = new System.Drawing.Point(25, 243);
            this.bubblesortCheckBox.Name = "bubblesortCheckBox";
            this.bubblesortCheckBox.Size = new System.Drawing.Size(76, 17);
            this.bubblesortCheckBox.TabIndex = 12;
            this.bubblesortCheckBox.Text = "Bubblesort";
            this.bubblesortCheckBox.UseVisualStyleBackColor = true;
            // 
            // quicksortTextBox
            // 
            this.quicksortTextBox.Location = new System.Drawing.Point(177, 137);
            this.quicksortTextBox.Name = "quicksortTextBox";
            this.quicksortTextBox.ReadOnly = true;
            this.quicksortTextBox.Size = new System.Drawing.Size(77, 20);
            this.quicksortTextBox.TabIndex = 11;
            this.quicksortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(176, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time (µs/run):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Algorithm:";
            // 
            // secsPerAlgTextBox
            // 
            this.secsPerAlgTextBox.Location = new System.Drawing.Point(82, 21);
            this.secsPerAlgTextBox.Name = "secsPerAlgTextBox";
            this.secsPerAlgTextBox.Size = new System.Drawing.Size(77, 20);
            this.secsPerAlgTextBox.TabIndex = 0;
            this.secsPerAlgTextBox.Text = "0.25";
            this.secsPerAlgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Secs/Alg:";
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(179, 19);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // quicksortCheckBox
            // 
            this.quicksortCheckBox.AutoSize = true;
            this.quicksortCheckBox.Checked = true;
            this.quicksortCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quicksortCheckBox.Location = new System.Drawing.Point(25, 139);
            this.quicksortCheckBox.Name = "quicksortCheckBox";
            this.quicksortCheckBox.Size = new System.Drawing.Size(71, 17);
            this.quicksortCheckBox.TabIndex = 0;
            this.quicksortCheckBox.Text = "Quicksort";
            this.quicksortCheckBox.UseVisualStyleBackColor = true;
            // 
            // unsortedListBox
            // 
            this.unsortedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unsortedListBox.FormattingEnabled = true;
            this.unsortedListBox.IntegralHeight = false;
            this.unsortedListBox.Location = new System.Drawing.Point(278, 36);
            this.unsortedListBox.Name = "unsortedListBox";
            this.unsortedListBox.Size = new System.Drawing.Size(120, 466);
            this.unsortedListBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(278, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unsorted";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(404, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sorted";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortedListBox
            // 
            this.sortedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.IntegralHeight = false;
            this.sortedListBox.Location = new System.Drawing.Point(404, 36);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(120, 466);
            this.sortedListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unsortedListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sorting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numValuesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bubblesortTextBox;
        private System.Windows.Forms.CheckBox bubblesortCheckBox;
        private System.Windows.Forms.TextBox quicksortTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.CheckBox quicksortCheckBox;
        private System.Windows.Forms.ListBox unsortedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox sortedListBox;
        private System.Windows.Forms.TextBox secsPerAlgTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox numUnsortedCheckBox;
        private System.Windows.Forms.TextBox numUnsortedTextBox;
        private System.Windows.Forms.TextBox bubblesort2TextBox;
        private System.Windows.Forms.CheckBox bubblesort2CheckBox;
        private System.Windows.Forms.TextBox selectionsortTextBox;
        private System.Windows.Forms.CheckBox selectionsortCheckBox;
        private System.Windows.Forms.TextBox insertionsortTextBox;
        private System.Windows.Forms.CheckBox insertionsortCheckBox;
        private System.Windows.Forms.TextBox heapsortTextBox;
        private System.Windows.Forms.CheckBox heapsortCheckBox;
        private System.Windows.Forms.TextBox mergesortTextBox;
        private System.Windows.Forms.CheckBox mergesortCheckBox;
        private System.Windows.Forms.TextBox mergesort2TextBox;
        private System.Windows.Forms.CheckBox mergesort2CheckBox;
        private System.Windows.Forms.TextBox countingsortTextBox;
        private System.Windows.Forms.CheckBox countingsortCheckBox;
    }
}

