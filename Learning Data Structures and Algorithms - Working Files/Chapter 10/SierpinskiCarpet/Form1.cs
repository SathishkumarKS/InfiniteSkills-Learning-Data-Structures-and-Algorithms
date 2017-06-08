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
//using System.Drawing.Imaging;

namespace SierpinskiCarpet
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
                carpetPictureBox.ClientSize.Width,
                carpetPictureBox.ClientSize.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Clear(Color.White);

                const int margin = 10;
                int depth = (int)depthNumericUpDown.Value;

                RectangleF rect = new RectangleF(margin, margin,
                    carpetPictureBox.ClientSize.Width - 2 * margin,
                    carpetPictureBox.ClientSize.Height - 2 * margin);
                SierpinskiCarpet(depth, gr, rect);

                //                bm.Save("Carpet" + depth.ToString() + ".png", ImageFormat.Png);
            }

            carpetPictureBox.Image = bm;
        }

        // Draw the carpet.
        private void SierpinskiCarpet(int depth, Graphics gr, RectangleF rect)
        {
            // If this is depth 0, fill the remaining rectangle.
            if (depth == 0)
            {
                //gr.DrawRectangle(Pens.Blue, rect.X, rect.Y, rect.Width, rect.Height);
                gr.FillRectangle(Brushes.Blue, rect);
            }
            else
            {
                // Fill the 8 outside rectangles.
                float width = rect.Width / 3f;
                float height = rect.Height / 3f;
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        // Skip the center rectangle.
                        if ((row != 1) || (col != 1))
                        {
                            SierpinskiCarpet(depth - 1, gr,
                                new RectangleF(
                                    rect.X + col * width,
                                    rect.Y + row * height,
                                    width, height));
                        }
                    }
                }
            }
        }
    }
}
