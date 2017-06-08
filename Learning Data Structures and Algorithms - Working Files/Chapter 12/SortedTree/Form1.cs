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

namespace SortedTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The root node.
        private TreeNode Root = new TreeNode(50);

        // The node right-clicked to display the context menu.
        private TreeNode SelectedNode = null;

        // Arrange and draw the initial tree.
        private void Form1_Load(object sender, EventArgs e)
        {
            //// Build a test tree.
            //Root = new TreeNode(20);
            //Root.AddNode(new TreeNode(9));
            //Root.AddNode(new TreeNode(29));

            //Root.AddNode(new TreeNode(5));
            //Root.AddNode(new TreeNode(12));
            //Root.AddNode(new TreeNode(25));
            //Root.AddNode(new TreeNode(32));

            //Root.AddNode(new TreeNode(2));
            //Root.AddNode(new TreeNode(11));
            //Root.AddNode(new TreeNode(16));
            //Root.AddNode(new TreeNode(21));
            //Root.AddNode(new TreeNode(28));

            //Root.AddNode(new TreeNode(26));

            ArrangeTree();
            ShowTraversals();
        }

        // Draw the tree.
        private void treePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.Clear(Color.White);

            if (Root != null)
                Root.DrawTree(e.Graphics, Brushes.LightBlue, Pens.Blue,
                    Brushes.Black, treePictureBox.Font);
        }

        // Center the tree on the form.
        private void treePictureBox_Resize(object sender, EventArgs e)
        {
            ArrangeTree();
        }
        private void ArrangeTree()
        {
            if (Root != null)
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
            }

            treePictureBox.Refresh();
        }

        // If the mouse is over a node, display the context menu.
        private void treePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Only work for the right button.
            if (e.Button != MouseButtons.Right) return;

            // Find the node under the mouse.
            if (Root == null) SelectedNode = null;
            else SelectedNode = Root.NodeAtPoint(e.Location);
            ctxNodeDelete.Enabled = (SelectedNode != null);

            // Display the context menu.
            ctxNode.Show(this, e.Location);
        }

        // Add a child to the clicked node.
        private void ctxNodeAddChild_Click(object sender, EventArgs e)
        {
            NodeTextDialog dlg = new NodeTextDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TreeNode child = new TreeNode(int.Parse(dlg.nodeValueTextBox.Text));
                if (Root == null) Root = child;
                else Root.AddNode(child);

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
                Root.DeleteNode(SelectedNode.Value, ref Root);

                // Rearrange the tree to show the new structure.
                ArrangeTree();

                // Show the tree's traversals.
                ShowTraversals();
            }
        }

        // Show the tree's traversals.
        private void ShowTraversals()
        {
            if (Root == null) return;

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
