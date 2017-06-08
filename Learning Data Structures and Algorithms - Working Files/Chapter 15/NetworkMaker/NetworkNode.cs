using System;
using System.Collections.Generic;

using System.Drawing;

namespace NetworkMaker
{
    public class NetworkNode
    {
        public static int Radius = 11;
        private static int RadiusSquared = Radius * Radius;

        public string Name;
        public string Text;
        public int Index;
        public PointF Location;
        public List<NetworkLink> Links = new List<NetworkLink>();

        // Properties used by algorithms.
        public bool Visited = false;

        // The node and link before this one in a spanning tree or path.
        public NetworkNode FromNode = null;
        public NetworkLink FromLink = null;

        // The distance from the root node to this node.
        public int Distance;

        // Return the node's current text.
        public override string ToString()
        {
            return Name;
        }

        // Draw the node.
        public void Draw(bool showText, Graphics gr, Pen pen, Brush brush, Brush textBrush,
            Font font, StringFormat sf)
        {
            // Fill and outline the node.
            RectangleF rect = new RectangleF(
                Location.X - Radius, Location.Y - Radius,
                2 * Radius, 2 * Radius);

            gr.FillEllipse(brush, rect);
            gr.DrawEllipse(pen, rect);

            // Draw the node's current text.
            if ((showText) && (Text != null))
                gr.DrawString(Text, font, textBrush, Location, sf);
            else gr.DrawString(Name, font, textBrush, Location, sf);
        }

        // Return true if the node is at the indicated location.
        public bool IsAt(PointF location)
        {
            float dx = Location.X - location.X;
            float dy = Location.Y - location.Y;
            return (dx * dx + dy * dy <= RadiusSquared);
        }

        // Add a link to the indicated node.
        public void AddLinkTo(NetworkNode node)
        {
            new NetworkLink(this, node);
        }
    }
}
