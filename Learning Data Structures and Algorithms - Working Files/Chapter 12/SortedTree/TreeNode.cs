using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SortedTree
{
    public class TreeNode
    {
        // The label used to draw the node.
        public string Name;

        // The node's value.
        public int Value;

        // Child nodes in the tree.
        public TreeNode LeftChild = null, RightChild = null;

        // Space to skip horizontally between siblings
        // and vertically between generations.
        private const float Hoffset = 5;
        private const float Voffset = 10;

        // Margin around the text.
        private const float TextMargin = 6;

        // The node's center and dimensions after arranging.
        private PointF Center;
        private RectangleF Bounds;

        // Constructor.
        public TreeNode(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public TreeNode(int value)
        {
            Name = value.ToString();
            Value = value;
        }

        // Return a list containing the node's non-null children.
        private List<TreeNode> Children
        {
            get
            {
                List<TreeNode> children = new List<TreeNode>();
                if (LeftChild != null) children.Add(LeftChild);
                if (RightChild != null) children.Add(RightChild);
                return children;
            }
        }

        // Arrange the node and its children in the allowed area.
        // Set xmin to indicate the right edge of our subtree.
        // Set ymin to indicate the bottom edge of our subtree.
        public void Arrange(Graphics gr, Font font, ref float xmin, ref float ymin)
        {
            // See how big this node is.
            SizeF mySize = gr.MeasureString(Name, font);
            mySize.Width += 2 * TextMargin;
            mySize.Height += 2 * TextMargin;

            // Recursively arrange our children, allowing room for this node.
            float biggestYmin = ymin + mySize.Height;
            float biggestWid = 0;
            float subtreeYmin = ymin + mySize.Height + Voffset;

            foreach (TreeNode child in Children)
            {
                // Arrange this child's subtree.
                float y = subtreeYmin;
                float x = 0;
                child.Arrange(gr, font, ref x, ref y);

                // See if this increases the biggest ymin value.
                if (biggestYmin < y) biggestYmin = y;

                // See if this increases the biggest width value.
                if (biggestWid < x) biggestWid = x;
            }

            // See how much width we need for the subtree.
            float subtreeWidth = 0;
            if (biggestWid > 0) subtreeWidth = 2 * biggestWid + Hoffset;

            // See if this node is wider than the subtree under it.
            float x1, x2;
            if (mySize.Width > subtreeWidth)
            {
                // Center the subtree under this node.
                x1 = xmin + (mySize.Width - subtreeWidth) / 2;
                x2 = xmin + (mySize.Width + subtreeWidth) / 2;

                // The subtree's width is this node's width.
                subtreeWidth = mySize.Width;
            }
            else
            {
                // Center the subtree under this node.
                x1 = xmin;
                x2 = xmin + biggestWid + Hoffset;
            }

            // Make the children rearrange themselves
            // moved to center their subtrees.
            float childYmin = subtreeYmin;
            if (LeftChild != null) LeftChild.Arrange(gr, font, ref x1, ref childYmin);
            childYmin = subtreeYmin;
            if (RightChild != null) RightChild.Arrange(gr, font, ref x2, ref childYmin);

            // Set this node's center position.
            Center = new PointF(
                xmin + subtreeWidth / 2,
                ymin + mySize.Height / 2);
            Bounds = new RectangleF(
                Center.X - mySize.Width / 2f,
                Center.Y - mySize.Height / 2f,
                mySize.Width, mySize.Height);

            // Increase xmin to allow room for
            // the subtree before returning.
            xmin += subtreeWidth;

            // Set the return value for ymin.
            ymin = biggestYmin;
        }

        // Shift all nodes by the indicated amount.
        public void Translate(float dx, float dy)
        {
            Center.X += dx;
            Center.Y += dy;
            Bounds.X += dx;
            Bounds.Y += dy;
            foreach (TreeNode child in Children) child.Translate(dx, dy);
        }

        // Draw the subtree rooted at this node with the given upper left corner.
        public void DrawTree(Graphics gr, Brush bgBrush, Pen pen, Brush fgBrush, Font font, ref float x, float y)
        {
            // Arrange the tree.
            Arrange(gr, font, ref x, ref y);

            // Draw the tree.
            DrawTree(gr, bgBrush, pen, fgBrush, font);
        }

        // Draw the subtree rooted at this node.
        public void DrawTree(Graphics gr, Brush bgBrush, Pen pen, Brush fgBrush, Font font)
        {
            // Draw the links.
            DrawSubtreeLinks(gr, pen);

            // Draw the nodes.
            DrawSubtreeNodes(gr, bgBrush, pen, fgBrush, font);
        }

        // Draw the links for the subtree rooted at this node.
        private void DrawSubtreeLinks(Graphics gr, Pen pen)
        {
            foreach (TreeNode child in Children)
            {
                // Draw the link between this node this child.
                gr.DrawLine(pen, Center, child.Center);

                // Recursively make the child draw its subtree nodes.
                child.DrawSubtreeLinks(gr, pen);
            }
        }

        // Draw the nodes for the subtree rooted at this node.
        private void DrawSubtreeNodes(Graphics gr, Brush bgBrush, Pen pen, Brush fgBrush, Font font)
        {
            // Draw this node.
            gr.FillEllipse(bgBrush, Bounds);
            gr.DrawEllipse(pen, Bounds);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                gr.DrawString(Name, font, fgBrush, Center, sf);
            }

            // Recursively make the child draw its subtree nodes.
            foreach (TreeNode child in Children)
            {
                child.DrawSubtreeNodes(gr, bgBrush, pen, fgBrush, font);
            }
        }

        // Return the TreeNode at this point (or null if there isn't one there).
        // Note: The equation for an ellipse with half width w and half height h centered at the origin is:
        //      x * x / w / w + y * y / h / h <= 1.
        public TreeNode NodeAtPoint(PointF targetPt)
        {
            // See if the point is under this node.
            float dx = targetPt.X - Center.X;
            float dy = targetPt.Y - Center.Y;
            float w = Bounds.Width / 2f;
            float h = Bounds.Height / 2f;
            if (dx * dx / w / w + dy * dy / h / h <= 1) return this;

            // See if the point is under a node in the subtree.
            foreach (TreeNode child in Children)
            {
                TreeNode hitNode = child.NodeAtPoint(targetPt);
                if (hitNode != null) return hitNode;
            }

            return null;
        }

        // Add a node to this node's subtree.
        public void AddNode(TreeNode node)
        {
            // See which subtree should hold it.
            if (node.Value < this.Value)
            {
                if (LeftChild == null) LeftChild = node;
                else LeftChild.AddNode(node);
            }
            else
            {
                if (RightChild == null) RightChild = node;
                else RightChild.AddNode(node);
            }
        }

        // Delete a node with a target value from this node's subtree.
        // Return true if we delete the node, false if it's not in the tree.
        //
        // The parameter linkToNode is the link that lead to this node.
        // The method uses it to update the parent's link to this child node,
        // for example, if it needs to change the parent's child.
        public bool DeleteNode(int targetValue, ref TreeNode linkToNode)
        {
            // See which subtree contains the target value.
            // This node doesn't hold the target value. Go deeper.
            if (targetValue < Value)
            {
                // Search the left subtree.
                if (LeftChild == null) return false;
                return LeftChild.DeleteNode(targetValue, ref LeftChild);
            }
            else if (targetValue > Value)
            {
                // Search the right subtree.
                if (RightChild == null) return false;
                return RightChild.DeleteNode(targetValue, ref RightChild);
            }
            else
            {
                // This is the node.
                // See if this is a leaf node.
                if ((LeftChild == null) && (RightChild == null))
                {
                    // This is a leaf node. Simply remove it.
                    linkToNode = null;
                    return true;
                }

                // See if we have one child.
                if (LeftChild == null)
                {
                    // Replace this node with its right child.
                    linkToNode = RightChild;
                    return true;
                }
                if (RightChild == null)
                {
                    // Replace this node with its left child.
                    linkToNode = LeftChild;
                    return true;
                }

                // We have two children. See if the left child has no right child.
                if (LeftChild.RightChild == null)
                {
                    // Replace this node with the left child.
                    LeftChild.RightChild = this.RightChild;
                    linkToNode = LeftChild;
                    return true;
                }

                // We have the hard case.
                // Find the parent of the righmost node in the left subtree.
                TreeNode rightmostParent = LeftChild.FindRightmostParent();
                TreeNode rightmost = rightmostParent.RightChild;
                TreeNode rightmostsLeftChild = rightmost.LeftChild;

                // Move the rightmost node into this position.
                rightmost.LeftChild = LeftChild;
                rightmost.RightChild = RightChild;
                linkToNode = rightmost;

                // Move the rightmost node's left child into the rightmost node's former position.
                rightmostParent.RightChild = rightmostsLeftChild;
                return true;
            }
        }

        // Find the parent of the rightmost node below this one.
        public TreeNode FindRightmostParent()
        {
            // See if this node's right child has no right child.
            if (RightChild.RightChild == null) return this;

            // Search deeper.
            return RightChild.FindRightmostParent();
        }

        // Perform a preorder traversal calling the indicated methods for each node.
        public void PreorderTraverse(Action<TreeNode> method)
        {
            // Call the method for this node.
            method(this);

            // Traverse the subtree.
            if (LeftChild != null) LeftChild.PreorderTraverse(method);
            if (RightChild != null) RightChild.PreorderTraverse(method);
        }

        // Perform an inorder traversal calling the indicated methods for each node.
        public void InorderTraverse(Action<TreeNode> method)
        {
            // Traverse the left subtree.
            if (LeftChild != null) LeftChild.InorderTraverse(method);

            // Call the method for this node.
            method(this);

            // Traverse the right subtree.
            if (RightChild != null) RightChild.InorderTraverse(method);
        }

        // Perform a postorder traversal calling the indicated methods for each node.
        public void PostorderTraverse(Action<TreeNode> method)
        {
            // Traverse the subtree.
            if (LeftChild != null) LeftChild.PostorderTraverse(method);
            if (RightChild != null) RightChild.PostorderTraverse(method);

            // Call the method for this node.
            method(this);
        }

        // Perform a breadth-first traversal calling the indicated methods for each node.
        public void BreadthFirstTraverse(Action<TreeNode> method)
        {
            // Initialize the stack.
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(this);

            // Process the stack until it's empty.
            while (stack.Count > 0)
            {
                // Get the next node and call the method for it.
                TreeNode node = stack.Pop();
                method(node);

                // Add the children to the stack.
                if (node.LeftChild != null) stack.Push(node.LeftChild);
                if (node.RightChild != null) stack.Push(node.RightChild);
            }
        }
    }
}
