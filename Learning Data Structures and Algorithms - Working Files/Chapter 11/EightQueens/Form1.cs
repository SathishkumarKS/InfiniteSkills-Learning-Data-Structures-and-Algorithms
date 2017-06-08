#define USE_COLOR
// #define SHOW_ATTACK_LINES

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

namespace EightQueens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The board dimensions.
        private const int NumRows = 8;
        private const int NumCols = 8;
        private const int NumQueens = 8;

        // The board.
        private bool[,] SpotTaken;

        // Draw the blank chess board.
        private void Form1_Load(object sender, EventArgs e)
        {
            boardPictureBox.Image = MakeClearBoard();
        }

        // Make a blank chess board.
        private Bitmap MakeClearBoard()
        {
            int wid = boardPictureBox.ClientSize.Width;
            int hgt = boardPictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                float colWid = wid / NumCols;
                float rowHgt = hgt / NumRows;
                for (int row = 0; row < NumRows; row++)
                {
                    for (int col = 0; col < NumCols; col++)
                    {
                        if ((row + col) % 2 == 0)
                        {
                            gr.FillRectangle(Brushes.White, col * colWid, row * rowHgt, colWid, rowHgt);
                        }
                        else
                        {
                            gr.FillRectangle(Brushes.LightGray, col * colWid, row * rowHgt, colWid, rowHgt);
                        }
                    }
                }
            }

            return bm;
        }

        // Make a chess board showing the solution.
        private Bitmap MakeSolutionBoard()
        {
            // Calculate some parameters.
            int wid = boardPictureBox.ClientSize.Width;
            int hgt = boardPictureBox.ClientSize.Height;
            float colWid = wid / NumCols;
            float rowHgt = hgt / NumRows;

            // Start with a clear board.
            Bitmap bm = MakeClearBoard();

            // Draw the queens.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                for (int row = 0; row < NumRows; row++)
                {
                    for (int col = 0; col < NumCols; col++)
                    {
                        if (SpotTaken[row, col])
                        {
                            DrawQueen(gr,
                                colWid * (col + 0.5f),
                                rowHgt * (row + 0.5f),
                                colWid * 0.4f,
                                rowHgt * 0.4f);
                        }
                    }
                }

#if SHOW_ATTACK_LINES
                // Draw the attack lines.
                for (int row = 0; row < NumRows; row++)
                {
                    for (int col = 0; col < NumCols; col++)
                    {
                        if (SpotTaken[row, col])
                        {
                            // Horizontal.
                            DrawAttackLines(gr, Pens.Red, rowHgt, colWid, row, col);
                        }
                    }
                }
#endif
            }

            return bm;
        }

        // Draw a queen.
        private void DrawQueen(Graphics gr, float x, float y, float rx, float ry)
        {
            // Make the points.
            const int numPoints = 7;
            PointF[] pts = new PointF[2 * numPoints];
            double theta = -Math.PI / 2.0;
            double dtheta = Math.PI / numPoints;
            for (int i = 0; i < 2 * numPoints; i += 2)
            {
                pts[i] = new PointF(
                    (float)(rx * Math.Cos(theta)),
                    (float)(ry * Math.Sin(theta)));
                theta += dtheta;
                pts[i + 1] = new PointF(
                    (float)(0.5 * rx * Math.Cos(theta)),
                    (float)(0.5 * ry * Math.Sin(theta)));
                theta += dtheta;
            }

            // Translate to position the queen.
            gr.TranslateTransform(x, y);

            // Draw the queen.
#if USE_COLOR
            gr.FillPolygon(Brushes.LightBlue, pts);
            gr.DrawPolygon(Pens.Blue, pts);
#else
            gr.FillPolygon(Brushes.Black, pts);
#endif

            // Cleat the transformation.
            gr.ResetTransform();
        }

        // Draw the attack lines for a queen in this position.
        private void DrawAttackLines(Graphics gr, Pen pen, float rowHgt, float colWid, int row, int col)
        {
            float x0 = colWid * 0;
            float x1 = colWid * col;
            float x2 = colWid * (col + 1);
            float x3 = colWid * 9;
            float xmid = colWid * (col + 0.5f);
            
            float y0 = rowHgt * 0;
            float y1 = rowHgt * row;
            float y2 = rowHgt * (row + 1);
            float y3 = rowHgt * 9;
            float ymid = rowHgt * (row + 0.5f);

            // Horizontal.
            gr.DrawLine(pen, x0, ymid, x1, ymid);
            gr.DrawLine(pen, x2, ymid, x3, ymid);

            // Vertical.
            gr.DrawLine(pen, xmid, y0, xmid, y1);
            gr.DrawLine(pen, xmid, y2, xmid, y3);

            // UL to LR.
            y0 = y1 - rowHgt * col;
            y3 = y2 + rowHgt * (8 - col);
            gr.DrawLine(pen, x0, y0, x1, y1);
            gr.DrawLine(pen, x2, y2, x3, y3);

            // LL to UR.
            y0 = y2 + rowHgt * col;
            y3 = y1 - rowHgt * (8 - col);
            gr.DrawLine(pen, x0, y0, x1, y2);
            gr.DrawLine(pen, x2, y1, x3, y3);
        }

        // Solve the problem and draw the chess board.
        private void solveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SpotTaken = new bool[NumRows, NumCols];

            int numAttempts = 0;
            DateTime startTime = DateTime.Now;
            bool success = EightQueens(SpotTaken, 0, ref numAttempts);
            DateTime stopTime = DateTime.Now;

            if (success)
            {
                // We have a solution. Display it.
                boardPictureBox.Image = MakeSolutionBoard();
            }
            else
            {
                // We did not find a solution. Clear the display.
                boardPictureBox.Image = MakeClearBoard();
                MessageBox.Show("No solution found.");
            }

            positionsTriedTextBox.Text = numAttempts.ToString();
            TimeSpan elapsed = stopTime - startTime;
            timeTextBox.Text = elapsed.TotalSeconds.ToString("0.00") + " sec";
            Cursor = Cursors.Default;
        }

        // Explore this test solution.
        // Return false if it cannot be extended to a full solution.
        // Return true if a recursive call to TestSolution finds a full solution.
        private bool EightQueens(bool[,] spotTaken, int numQueensPositioned, ref int numAttempts)
        {
            // See if the test solution is already illegal.
            if (!IsLegal(spotTaken)) return false;

            // See if we have positioned all of the queens.
            if (numQueensPositioned == NumQueens) return true;

            // Extend the partial solution.
            // Try all positions for the next queen.
            for (int row = 0; row < NumRows; row++)
            {
                for (int col = 0; col < NumCols; col++)
                {
                    if (!spotTaken[row, col])
                    {
                        numAttempts++;
                        spotTaken[row, col] = true;

                        // Recursively see if this leads to a solution.
                        if (EightQueens(spotTaken, numQueensPositioned + 1, ref numAttempts))
                            return true;

                        // The extension did not lead to a solution. Undo the change.
                        spotTaken[row, col] = false;
                    }
                }
            }

            // If we get here, we could not find a valid solution.
            return false;
        }

        // Return true if this board position is legal.
        private bool IsLegal(bool[,] spotTaken)
        {
            for (int row = 0; row < NumRows; row++)
            {
                for (int col = 0; col < NumCols; col++)
                {
                    // See if this position is taken.
                    if (spotTaken[row, col])
                    {
                        // See if this position attacks another queen.
                        // Check the row.
                        for (int c = 0; c < NumCols; c++)
                        {
                            if ((c != col) && spotTaken[row, c]) return false;
                        }
                        // Check the column.
                        for (int r = 0; r < NumRows; r++)
                        {
                            if ((r != row) && spotTaken[r, col]) return false;
                        }

                        // Check the upper left/lower right diagonal.
                        int minDx1 = -Math.Min(row, col);
                        int maxDx1 = Math.Min(NumRows - row - 1, NumCols - col - 1);
                        for (int dx = minDx1; dx <= maxDx1; dx++)
                        {
                            // Skip this queen's position.
                            if (dx != 0)
                            {
                                // See if there is a queen here.
                                if (spotTaken[row + dx, col + dx]) return false;
                            }
                        }

                        // Check the upper right/lower left diagonal.
                        int minDx2 = -Math.Min(row, NumCols - col - 1);
                        int maxDx2 = Math.Min(NumRows - row - 1, col);
                        for (int dx = minDx2; dx <= maxDx2; dx++)
                        {
                            // Skip this queen's position.
                            if (dx != 0)
                            {
                                // See if there is a queen here.
                                if (spotTaken[row + dx, col - dx]) return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
