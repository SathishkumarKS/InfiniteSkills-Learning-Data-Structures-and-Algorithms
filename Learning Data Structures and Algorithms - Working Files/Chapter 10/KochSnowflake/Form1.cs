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
using System.Drawing.Imaging;

namespace KochSnowflake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int depth = (int)depthNumericUpDown.Value;

            Bitmap bm = new Bitmap(
                snowflakePictureBox.ClientSize.Width,
                snowflakePictureBox.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Blue, 0))
                {
                    // Figure out where to put the corners.
                    const int margin = 5;
                    int h = bm.Height - 2 * margin;
                    float l = h / 2;
                    float y = margin + l / 2;
                    float length = (float)(l * Math.Sqrt(3));
                    float x = (bm.Width - length) / 2;
                    PointF pt1 = new PointF(x, y);
                    PointF pt2 = new PointF(x + length, y);
                    PointF pt3 = new PointF(
                        (float)(x + length * Math.Cos(Math.PI / 3)),
                        (float)(y + length * Math.Sin(Math.PI / 3)));

                    // Draw the sides.
                    DrawKoch(gr, pen, depth, pt1, 0, length);
                    DrawKoch(gr, pen, depth, pt2, Math.PI * 2 / 3, length);
                    DrawKoch(gr, pen, depth, pt3, -Math.PI * 2 / 3, length);
                }
            }
            snowflakePictureBox.Image = bm;
            bm.Save("KochSnowflake" + depth.ToString() + ".jpg", ImageFormat.Png);
        }

        private void DrawKoch(Graphics gr, Pen pen, int depth, PointF pt1, double angle, float length)
        {
            if (depth == 0)
            {
                PointF pt2 = new PointF(
                    (float)(pt1.X + length * Math.Cos(angle)),
                    (float)(pt1.Y + length * Math.Sin(angle)));
                gr.DrawLine(pen, pt1, pt2);
            }
            else
            {
                PointF pt2 = new PointF(
                    (float)(pt1.X + length / 3 * Math.Cos(angle)),
                    (float)(pt1.Y + length / 3 * Math.Sin(angle)));

                double theta1 = angle - Math.PI / 3;
                double theta2 = angle + Math.PI / 3;
                PointF pt3 = new PointF(
                    (float)(pt2.X + length / 3 * Math.Cos(theta1)),
                    (float)(pt2.Y + length / 3 * Math.Sin(theta1)));

                PointF pt4 = new PointF(
                    (float)(pt1.X + length * 2 / 3 * Math.Cos(angle)),
                    (float)(pt1.Y + length * 2 / 3 * Math.Sin(angle)));

                DrawKoch(gr, pen, depth - 1, pt1, angle, length / 3);
                DrawKoch(gr, pen, depth - 1, pt2, theta1, length / 3);
                DrawKoch(gr, pen, depth - 1, pt3, theta2, length / 3);
                DrawKoch(gr, pen, depth - 1, pt4, angle, length / 3);
            }
        }
    }
}
