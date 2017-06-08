using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace TreeEditor
{
    public class TreeNode
    {
        // The node's label.
        public string Name;

        // Child nodes in the tree.
        public List<TreeNode> Children = new List<TreeNode>();

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
        public TreeNode(string name)
        {
            Name = name;
        }

        // Add a TreeNode to the Children list.
        public void AddChild(TreeNode child)
        {
            Children.Add(child);
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
            float x = xmin;
            float biggestYmin = ymin + mySize.Height;
            float subtreeYmin = ymin + mySize.Height + Voffset;
            foreach (TreeNode child in Children)
            {
                // Arrange this child's subtree.
                float childYmin = subtreeYmin;
                child.Arrange(gr, font, ref x, ref childYmin);

                // See if this increases the biggest ymin value.
                if (biggestYmin < childYmin) biggestYmin = childYmin;

                // Allow room before the next sibling.
                x += Hoffset;
            }

            // Remove the spacing after the last child.
            if (Children.Count > 0) x -= Hoffset;

            // See if this node is wider than the subtree under it.
            float subtreeWidth = x - xmin;
            if (mySize.Width > subtreeWidth)
            {
                // Center the subtree under this node.
                // Make the children rearrange themselves
                // moved to center their subtrees.
                x = xmin + (mySize.Width - subtreeWidth) / 2;
                foreach (TreeNode child in Children)
                {
                    // Arrange this child's subtree.
                    child.Arrange(gr, font, ref x, ref subtreeYmin);

                    // Allow room before the next sibling.
                    x += Hoffset;
                }

                // The subtree's width is this node's width.
                subtreeWidth = mySize.Width;
            }

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

        // Delete a target node from this node's subtree.
        // Return true if we delete the node.
        public bool DeleteNode(TreeNode target)
        {
            // See if the target is a child of this node.
            if (Children.Contains(target))
            {
                // Remove the child (and its subtree).
                Children.Remove(target);
                return true;
            }
            else
            {
                // Recursively remove the target from the child subtrees.
                // Stop searching and return true if a child subtree contains the target.
                foreach (TreeNode child in Children)
                    if (child.DeleteNode(target)) return true;
            }

            // It's not in our subtree.
            return false;
        }

        // Perform a preorder traversal calling the indicated methods for each node.
        public void PreorderTraverse(Action<TreeNode> method)
        {
            // Call the method for this node.
            method(this);

            // Traverse the subtree.
            foreach (TreeNode child in Children) child.PreorderTraverse(method);
        }

        // Perform an inorder traversal calling the indicated methods for each node.
        public void InorderTraverse(Action<TreeNode> method)
        {
            // Pick the dividing value (rounding up).
            int mid = (Children.Count + 1) / 2;

            // Traverse the left half of the subtree.
            for (int i = 0; i < mid; i++) Children[i].InorderTraverse(method);

            // Call the method for this node.
            method(this);

            // Traverse the rest of the subtree.
            for (int i = mid; i < Children.Count; i++) Children[i].InorderTraverse(method);
        }

        // Perform a postorder traversal calling the indicated methods for each node.
        public void PostorderTraverse(Action<TreeNode> method)
        {
            // Traverse the subtree.
            foreach (TreeNode child in Children) child.PostorderTraverse(method);

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
                foreach (TreeNode child in node.Children) stack.Push(child);
            }
        }
    }
}
