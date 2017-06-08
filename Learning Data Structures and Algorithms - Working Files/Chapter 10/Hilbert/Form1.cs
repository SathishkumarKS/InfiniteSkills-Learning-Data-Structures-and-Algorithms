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

namespace Hilbert
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
                hilbertPictureBox.ClientSize.Width,
                hilbertPictureBox.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Clear(Color.White);

                const int margin = 10;
                int depth = (int)depthNumericUpDown.Value;
                float dx = (float)((bm.Width - 2 * margin) / (Math.Pow(2, depth + 1) - 1));
                CurrentX = margin;
                CurrentY = margin;
                Hilbert(depth, gr, dx, 0);
            }

            hilbertPictureBox.Image = bm;
        }

        // The current position.
        private float CurrentX, CurrentY;

        // Draw the Hilbert curve.
        private void Hilbert(int depth, Graphics gr, float dx, float dy)
        {
            if (depth > 0) Hilbert(depth - 1, gr, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 0) Hilbert(depth - 1, gr, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 0) Hilbert(depth - 1, gr, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 0) Hilbert(depth - 1, gr, -dy, -dx);
        }

        // Draw starting at the indicated point and update x and y.
        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Blue,
                CurrentX, CurrentY,
                CurrentX + dx, CurrentY + dy);
            CurrentX += dx;
            CurrentY += dy;
        }
    }
}
