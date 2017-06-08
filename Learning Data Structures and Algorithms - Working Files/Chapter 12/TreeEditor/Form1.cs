using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace TreeEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The root node.
        private TreeNode Root = new TreeNode("Root");

        // The node right-clicked to display the context menu.
        private TreeNode SelectedNode = null;

        // Arrange and draw the initial tree.
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrangeTree();
            ShowTraversals();
        }

        // Draw the tree.
        private void treePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            Root.DrawTree(e.Graphics, Brushes.LightBlue, Pens.Blue, Brushes.Black, treePictureBox.Font);
        }

        // Center the tree on the form.
        private void treePictureBox_Resize(object sender, EventArgs e)
        {
            ArrangeTree();
        }
        private void ArrangeTree()
        {
            using (Graphics gr = treePictureBox.CreateGraphics())
            {
                // Arrange the tree once to see how big it is.
                float xmin = 0, ymin = 10;
                Root.Arrange(gr, treePictureBox.Font, ref xmin, ref ymin);

                // Translate the tree to center it.
                float dx = (treePictureBox.ClientSize.Width - xmin) / 2f;
                Root.Translate(dx, 0);
            }

            treePictureBox.Refresh();
        }

        // Display an appropriate cursor.
        private void treePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor newCursor = Cursors.Cross;
            if (Root.NodeAtPoint(e.Location) != null) newCursor = Cursors.Default;
            if (treePictureBox.Cursor != newCursor) treePictureBox.Cursor = newCursor;
        }

        // If the mouse is over a node, display the context menu.
        private void treePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Only work for the right button.
            if (e.Button != MouseButtons.Right) return;

            // Find the node under the mouse.
            SelectedNode = Root.NodeAtPoint(e.Location);

            // If there is a node under the mouse, display the context menu.
            if (SelectedNode != null)
            {
                // Don't let the user delete the root node.
                ctxNodeDelete.Enabled = (SelectedNode != Root);

                // Display the context menu.
                ctxNode.Show(this, e.Location);
            }
        }

        // Add a child to the clicked node.
        private void ctxNodeAddChild_Click(object sender, EventArgs e)
        {
            NodeTextDialog dlg = new NodeTextDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TreeNode child = new TreeNode(dlg.nodeLabelTextBox.Text);
                SelectedNode.AddChild(child);

                // Rearrange the tree to show the new node.
                ArrangeTree();
                ShowTraversals();
            }
        }

        // Delete the clicked node.
        private void ctxNodeDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete node " + 
                SelectedNode.Name + "?",
                "Delete Node?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete the node (and its subtree).
                Root.DeleteNode(SelectedNode);

                // Rearrange the tree to show the new structure.
                ArrangeTree();

                // Show the tree's traversals.
                ShowTraversals();
            }
        }

        // Show the tree's traversals.
        private void ShowTraversals()
        {
            Traversal = new List<string>();
            Root.PreorderTraverse(MakeTraversal);
            preorderTextBox.Text = string.Join(", ", Traversal.ToArray());

            Traversal = new List<string>();
            Root.InorderTraverse(MakeTraversal);
            inorderTextBox.Text = string.Join(", ", Traversal.ToArray());

            Traversal = new List<string>();
            Root.PostorderTraverse(MakeTraversal);
            postorderTextBox.Text = string.Join(", ", Traversal.ToArray());

            Traversal = new List<string>();
            Root.BreadthFirstTraverse(MakeTraversal);
            breadthFirstTextBox.Text = string.Join(", ", Traversal.ToArray());            
        }

        // Add this node to the traversal.
        private List<string> Traversal;
        private void MakeTraversal(TreeNode node)
        {
            Traversal.Add(node.Name);
        }
    }
}
