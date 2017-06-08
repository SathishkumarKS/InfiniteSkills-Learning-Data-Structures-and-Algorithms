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

namespace SierpinskiTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(
                gasketPictureBox.ClientSize.Width,
                gasketPictureBox.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Clear(Color.White);

                const int margin = 10;
                int depth = (int)depthNumericUpDown.Value;

                PointF point1 = new PointF(bm.Width / 2, margin);
                PointF point2 = new PointF(margin, bm.Height - margin);
                PointF point3 = new PointF(bm.Width - margin, bm.Height - margin);

                SierpinskiGasket(depth, gr, point1, point2, point3);

                //                bm.Save("Gasket" + depth.ToString() + ".png", ImageFormat.Png);
            }

            gasketPictureBox.Image = bm;
        }

        // Draw the gasket.
        private void SierpinskiGasket(int depth, Graphics gr, PointF point1, PointF point2, PointF point3)
        {
            // If this is depth 0, fill the remaining triangle.
            if (depth == 0)
            {
                PointF[] points = { point1, point2, point3 };
                //gr.DrawPolygon(Pens.Red, points);
                gr.FillPolygon(Brushes.Red, points);
            }
            else
            {
                // Find points on the left, right, and bottom of the triangle.
                PointF lpoint = new PointF(
                    (point1.X + point2.X) / 2,
                    (point1.Y + point2.Y) / 2);
                PointF bpoint = new PointF(
                    (point2.X + point3.X) / 2,
                    (point2.Y + point3.Y) / 2);
                PointF rpoint = new PointF(
                    (point3.X + point1.X) / 2,
                    (point3.Y + point1.Y) / 2);

                // Draw the triangles at the corners.
                SierpinskiGasket(depth - 1, gr, point1, lpoint, rpoint);
                SierpinskiGasket(depth - 1, gr, lpoint, point2, bpoint);
                SierpinskiGasket(depth - 1, gr, rpoint, bpoint, point3);
            }
        }
    }
}
