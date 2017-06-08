namespace NetworkMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addLinkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addLink2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dfTraverseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bfTraverseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.connectedComponentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.spanningTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.minimalSpanningTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.anyPathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelSettingTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelSettingPathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelCorrectingTreeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelCorrectingPathToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.allPairsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.networkPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLinkCostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLinkCapacitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showNodeNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNodeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(476, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripButton,
            this.addLinkToolStripButton,
            this.addLink2ToolStripButton,
            this.toolStripSeparator1,
            this.dfTraverseToolStripButton,
            this.bfTraverseToolStripButton,
            this.connectedComponentsToolStripButton,
            this.spanningTreeToolStripButton,
            this.minimalSpanningTreeToolStripButton,
            this.anyPathToolStripButton,
            this.labelSettingTreeToolStripButton,
            this.labelSettingPathToolStripButton,
            this.labelCorrectingTreeToolStripButton,
            this.labelCorrectingPathToolStripButton,
            this.allPairsToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 26);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNodeToolStripButton
            // 
            this.addNodeToolStripButton.CheckOnClick = true;
            this.addNodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNodeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addNodeToolStripButton.Image")));
            this.addNodeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNodeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNodeToolStripButton.Name = "addNodeToolStripButton";
            this.addNodeToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.addNodeToolStripButton.Text = "toolStripButton1";
            this.addNodeToolStripButton.ToolTipText = "Add nodes";
            this.addNodeToolStripButton.Click += new System.EventHandler(this.addNodeToolStripButton_Click);
            // 
            // addLinkToolStripButton
            // 
            this.addLinkToolStripButton.CheckOnClick = true;
            this.addLinkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addLinkToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addLinkToolStripButton.Image")));
            this.addLinkToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addLinkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addLinkToolStripButton.Name = "addLinkToolStripButton";
            this.addLinkToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.addLinkToolStripButton.Text = "toolStripButton3";
            this.addLinkToolStripButton.ToolTipText = "Add one-way links";
            this.addLinkToolStripButton.Click += new System.EventHandler(this.addLinkToolStripButton_Click);
            // 
            // addLink2ToolStripButton
            // 
            this.addLink2ToolStripButton.CheckOnClick = true;
            this.addLink2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addLink2ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addLink2ToolStripButton.Image")));
            this.addLink2ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addLink2ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addLink2ToolStripButton.Name = "addLink2ToolStripButton";
            this.addLink2ToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.addLink2ToolStripButton.Text = "toolStripButton1";
            this.addLink2ToolStripButton.ToolTipText = "Add two-way links";
            this.addLink2ToolStripButton.Click += new System.EventHandler(this.addLink2ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // dfTraverseToolStripButton
            // 
            this.dfTraverseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dfTraverseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("dfTraverseToolStripButton.Image")));
            this.dfTraverseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dfTraverseToolStripButton.Name = "dfTraverseToolStripButton";
            this.dfTraverseToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.dfTraverseToolStripButton.Text = "toolStripButton1";
            this.dfTraverseToolStripButton.ToolTipText = "Depth-first traversal";
            this.dfTraverseToolStripButton.Click += new System.EventHandler(this.dfTraverseToolStripButton_Click);
            // 
            // bfTraverseToolStripButton
            // 
            this.bfTraverseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bfTraverseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bfTraverseToolStripButton.Image")));
            this.bfTraverseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bfTraverseToolStripButton.Name = "bfTraverseToolStripButton";
            this.bfTraverseToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.bfTraverseToolStripButton.Text = "toolStripButton1";
            this.bfTraverseToolStripButton.ToolTipText = "Breadth-first traversal";
            this.bfTraverseToolStripButton.Click += new System.EventHandler(this.bfTraverseToolStripButton_Click);
            // 
            // connectedComponentsToolStripButton
            // 
            this.connectedComponentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectedComponentsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connectedComponentsToolStripButton.Image")));
            this.connectedComponentsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectedComponentsToolStripButton.Name = "connectedComponentsToolStripButton";
            this.connectedComponentsToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.connectedComponentsToolStripButton.Text = "toolStripButton1";
            this.connectedComponentsToolStripButton.ToolTipText = "Find connected components";
            this.connectedComponentsToolStripButton.Click += new System.EventHandler(this.connectedComponentsToolStripButton_Click);
            // 
            // spanningTreeToolStripButton
            // 
            this.spanningTreeToolStripButton.CheckOnClick = true;
            this.spanningTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spanningTreeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("spanningTreeToolStripButton.Image")));
            this.spanningTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spanningTreeToolStripButton.Name = "spanningTreeToolStripButton";
            this.spanningTreeToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.spanningTreeToolStripButton.Text = "toolStripButton1";
            this.spanningTreeToolStripButton.ToolTipText = "Find spanning tree";
            this.spanningTreeToolStripButton.Click += new System.EventHandler(this.spanningTreeToolStripButton_Click);
            // 
            // minimalSpanningTreeToolStripButton
            // 
            this.minimalSpanningTreeToolStripButton.CheckOnClick = true;
            this.minimalSpanningTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minimalSpanningTreeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("minimalSpanningTreeToolStripButton.Image")));
            this.minimalSpanningTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minimalSpanningTreeToolStripButton.Name = "minimalSpanningTreeToolStripButton";
            this.minimalSpanningTreeToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.minimalSpanningTreeToolStripButton.Text = "toolStripButton1";
            this.minimalSpanningTreeToolStripButton.ToolTipText = "Find minimal spanning tree";
            this.minimalSpanningTreeToolStripButton.Click += new System.EventHandler(this.minimalSpanningTreeToolStripButton_Click);
            // 
            // anyPathToolStripButton
            // 
            this.anyPathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anyPathToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("anyPathToolStripButton.Image")));
            this.anyPathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anyPathToolStripButton.Name = "anyPathToolStripButton";
            this.anyPathToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.anyPathToolStripButton.Text = "toolStripButton1";
            this.anyPathToolStripButton.ToolTipText = "Find any path";
            this.anyPathToolStripButton.Click += new System.EventHandler(this.anyPathToolStripButton_Click);
            // 
            // labelSettingTreeToolStripButton
            // 
            this.labelSettingTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelSettingTreeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("labelSettingTreeToolStripButton.Image")));
            this.labelSettingTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelSettingTreeToolStripButton.Name = "labelSettingTreeToolStripButton";
            this.labelSettingTreeToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.labelSettingTreeToolStripButton.Text = "toolStripButton1";
            this.labelSettingTreeToolStripButton.ToolTipText = "Find a label setting shortest path tree";
            this.labelSettingTreeToolStripButton.Click += new System.EventHandler(this.labelSettingTreeToolStripButton_Click);
            // 
            // labelSettingPathToolStripButton
            // 
            this.labelSettingPathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelSettingPathToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("labelSettingPathToolStripButton.Image")));
            this.labelSettingPathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelSettingPathToolStripButton.Name = "labelSettingPathToolStripButton";
            this.labelSettingPathToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.labelSettingPathToolStripButton.Text = "toolStripButton1";
            this.labelSettingPathToolStripButton.ToolTipText = "Find a label setting shortest path";
            this.labelSettingPathToolStripButton.Click += new System.EventHandler(this.labelSettingPathToolStripButton_Click);
            // 
            // labelCorrectingTreeToolStripButton
            // 
            this.labelCorrectingTreeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelCorrectingTreeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("labelCorrectingTreeToolStripButton.Image")));
            this.labelCorrectingTreeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelCorrectingTreeToolStripButton.Name = "labelCorrectingTreeToolStripButton";
            this.labelCorrectingTreeToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.labelCorrectingTreeToolStripButton.Text = "toolStripButton1";
            this.labelCorrectingTreeToolStripButton.ToolTipText = "Find a label correcting shortest path tree";
            this.labelCorrectingTreeToolStripButton.Click += new System.EventHandler(this.labelCorrectingTreeToolStripButton_Click);
            // 
            // labelCorrectingPathToolStripButton
            // 
            this.labelCorrectingPathToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labelCorrectingPathToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("labelCorrectingPathToolStripButton.Image")));
            this.labelCorrectingPathToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.labelCorrectingPathToolStripButton.Name = "labelCorrectingPathToolStripButton";
            this.labelCorrectingPathToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.labelCorrectingPathToolStripButton.Text = "toolStripButton1";
            this.labelCorrectingPathToolStripButton.ToolTipText = "Find a label correcting shortest path";
            this.labelCorrectingPathToolStripButton.Click += new System.EventHandler(this.labelCorrectingPathToolStripButton_Click);
            // 
            // allPairsToolStripButton
            // 
            this.allPairsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.allPairsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("allPairsToolStripButton.Image")));
            this.allPairsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allPairsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allPairsToolStripButton.Name = "allPairsToolStripButton";
            this.allPairsToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.allPairsToolStripButton.Text = "toolStripButton1";
            this.allPairsToolStripButton.ToolTipText = "All pairs shortest paths";
            this.allPairsToolStripButton.Click += new System.EventHandler(this.allPairsToolStripButton_Click);
            // 
            // networkPictureBox
            // 
            this.networkPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.networkPictureBox.BackColor = System.Drawing.Color.White;
            this.networkPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.networkPictureBox.Location = new System.Drawing.Point(12, 52);
            this.networkPictureBox.Name = "networkPictureBox";
            this.networkPictureBox.Size = new System.Drawing.Size(452, 297);
            this.networkPictureBox.TabIndex = 5;
            this.networkPictureBox.TabStop = false;
            this.networkPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.networkPictureBox_Paint);
            this.networkPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.networkPictureBox_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLinkCostsToolStripMenuItem,
            this.showLinkCapacitiesToolStripMenuItem,
            this.toolStripSeparator2,
            this.showNodeNamesToolStripMenuItem,
            this.showNodeTextToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // showLinkCostsToolStripMenuItem
            // 
            this.showLinkCostsToolStripMenuItem.CheckOnClick = true;
            this.showLinkCostsToolStripMenuItem.Name = "showLinkCostsToolStripMenuItem";
            this.showLinkCostsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showLinkCostsToolStripMenuItem.Text = "Show Link &Costs";
            this.showLinkCostsToolStripMenuItem.Click += new System.EventHandler(this.showLinkCostsToolStripMenuItem_Click);
            // 
            // showLinkCapacitiesToolStripMenuItem
            // 
            this.showLinkCapacitiesToolStripMenuItem.CheckOnClick = true;
            this.showLinkCapacitiesToolStripMenuItem.Name = "showLinkCapacitiesToolStripMenuItem";
            this.showLinkCapacitiesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showLinkCapacitiesToolStripMenuItem.Text = "Show Link C&apacities";
            this.showLinkCapacitiesToolStripMenuItem.Click += new System.EventHandler(this.showLinkCapacitiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // showNodeNamesToolStripMenuItem
            // 
            this.showNodeNamesToolStripMenuItem.Checked = true;
            this.showNodeNamesToolStripMenuItem.CheckOnClick = true;
            this.showNodeNamesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNodeNamesToolStripMenuItem.Name = "showNodeNamesToolStripMenuItem";
            this.showNodeNamesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showNodeNamesToolStripMenuItem.Text = "Show Node &Names";
            this.showNodeNamesToolStripMenuItem.Click += new System.EventHandler(this.showNodeNamesToolStripMenuItem_Click);
            // 
            // showNodeTextToolStripMenuItem
            // 
            this.showNodeTextToolStripMenuItem.CheckOnClick = true;
            this.showNodeTextToolStripMenuItem.Name = "showNodeTextToolStripMenuItem";
            this.showNodeTextToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showNodeTextToolStripMenuItem.Text = "Show Node &Text";
            this.showNodeTextToolStripMenuItem.Click += new System.EventHandler(this.showNodeTextToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Network Files|*.net|All Files|*.*";
            this.saveFileDialog1.Title = "Select Network File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Network Files|*.net|All Files|*.*";
            this.openFileDialog1.Title = "Select Network File";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(461, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 374);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.networkPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "NetworkMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNodeToolStripButton;
        private System.Windows.Forms.ToolStripButton addLinkToolStripButton;
        private System.Windows.Forms.ToolStripButton addLink2ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton dfTraverseToolStripButton;
        private System.Windows.Forms.ToolStripButton bfTraverseToolStripButton;
        private System.Windows.Forms.ToolStripButton connectedComponentsToolStripButton;
        private System.Windows.Forms.ToolStripButton spanningTreeToolStripButton;
        private System.Windows.Forms.ToolStripButton minimalSpanningTreeToolStripButton;
        private System.Windows.Forms.ToolStripButton anyPathToolStripButton;
        private System.Windows.Forms.ToolStripButton labelSettingTreeToolStripButton;
        private System.Windows.Forms.ToolStripButton labelSettingPathToolStripButton;
        private System.Windows.Forms.ToolStripButton labelCorrectingTreeToolStripButton;
        private System.Windows.Forms.ToolStripButton labelCorrectingPathToolStripButton;
        private System.Windows.Forms.ToolStripButton allPairsToolStripButton;
        private System.Windows.Forms.PictureBox networkPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLinkCostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLinkCapacitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showNodeNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNodeTextToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

