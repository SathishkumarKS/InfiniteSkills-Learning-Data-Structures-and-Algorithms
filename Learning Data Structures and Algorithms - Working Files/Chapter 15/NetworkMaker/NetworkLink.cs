using System;
using System.Collections.Generic;

using System.Drawing;

namespace NetworkMaker
{
    public class NetworkLink
    {
        public NetworkNode[] Nodes = new NetworkNode[2];
        public int Cost, Capacity;

        // Properties used by algorithms.
        public bool Visited = false;

        public NetworkLink()
        {
        }

        // Used to make random capacities.
        private Random Rand = new Random();

        // Make a link between the two nodes.
        public NetworkLink(NetworkNode node0, NetworkNode node1)
        {
            Nodes[0] = node0;
            Nodes[1] = node1;

            float dx = node0.Location.X - node1.Location.X;
            float dy = node0.Location.Y - node1.Location.Y;
            Cost = (int)Math.Sqrt(dx * dx + dy * dy);

            Capacity = Rand.Next(1, 3) + Rand.Next(0, 3);

            node0.Links.Add(this);
        }

        // Return the names of the nodes.
        public override string ToString()
        {
            return Nodes[0].Name + " --> " + Nodes[1].Name;
        }

        // Draw the link.
        public void Draw(bool showCosts, bool showCapacities,
            Graphics gr, Pen pen, Brush brush, Font font, StringFormat sf)
        {
            float dx = Nodes[1].Location.X - Nodes[0].Location.X;
            float dy = Nodes[1].Location.Y - Nodes[0].Location.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            float nx = dx / dist;
            float ny = dy / dist;
            PointF head = new PointF(
                Nodes[1].Location.X - NetworkNode.Radius * nx,
                Nodes[1].Location.Y - NetworkNode.Radius * ny);

            // Draw the link.
            gr.DrawLine(pen, Nodes[0].Location, Nodes[1].Location);
            DrawArrowhead(gr, pen, head, nx, ny, NetworkNode.Radius / 2f);

            // Draw the link's cost.
            if (showCosts)
            {
                dx *= 3 * NetworkNode.Radius / dist;
                dy *= 3 * NetworkNode.Radius / dist;

                gr.DrawString(Cost.ToString("0"), font, brush,
                    Nodes[0].Location.X + dx,
                    Nodes[0].Location.Y + dy, sf);
            }

            // Draw the link's capacity.
            if (showCapacities)
            {
                dx *= 3 * NetworkNode.Radius / dist;
                dy *= 3 * NetworkNode.Radius / dist;

                gr.DrawString(Capacity.ToString("0"), font, brush,
                    Nodes[0].Location.X + dx,
                    Nodes[0].Location.Y + dy, sf);
            }
        }

        // Draw an arrowhead at the given point
        // in the normalized direction <nx, ny>.
        private void DrawArrowhead(Graphics gr, Pen pen,
            PointF p, float nx, float ny, float length)
        {
            float ax = length * (-ny - nx);
            float ay = length * (nx - ny);
            PointF[] points =
            {
                new PointF(p.X + ax, p.Y + ay),
                p,
                new PointF(p.X - ay, p.Y + ax)
            };
            gr.DrawLines(pen, points);
        }
    }
}
