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

namespace KnightsTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The board dimensions.
        private int NumRows, NumCols, NumSquares;

        // The board.
        private int[,] MoveNumber;

        // Draw the blank chess board.
        private void Form1_Load(object sender, EventArgs e)
        {
            NumRows = int.Parse(numRowsTextBox.Text);
            NumCols = int.Parse(numColsTextBox.Text);
            NumSquares = NumRows * NumCols;
            MoveNumber = new int[NumRows, NumCols];

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
                            gr.FillRectangle(Brushes.Gray, col * colWid, row * rowHgt, colWid, rowHgt);
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

            // Draw the moves.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                List<PointF> pts = new List<PointF>();
                for (int i = 1; i <= NumRows * NumCols; i++)
                {
                    bool foundIt = false;
                    for (int row = 0; row < NumRows; row++)
                    {
                        for (int col = 0; col < NumCols; col++)
                        {
                            if (MoveNumber[row, col] == i)
                            {
                                pts.Add(new PointF(
                                    colWid * (col + 0.5f),
                                    rowHgt * (row + 0.5f)));
                                foundIt = true;
                                break;
                            }
                        }
                        if (foundIt) break;
                    }
                }
                gr.DrawLines(Pens.Red, pts.ToArray());
                //gr.DrawLines(Pens.DarkGray, pts.ToArray());

                using (Font font = new Font("Times New Roman", 12, FontStyle.Bold))
                {
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        float y = rowHgt / 2f;
                        for (int row = 0; row < NumRows; row++)
                        {
                            float x = colWid / 2f;
                            for (int col = 0; col < NumCols; col++)
                            {
                                gr.DrawString(MoveNumber[row, col].ToString(),
                                    font, Brushes.Black,
                                    colWid * (col + 0.5f),
                                    rowHgt * (row + 0.5f),
                                    sf);
                                x += colWid;
                            }
                            y += rowHgt;
                        }
                    }
                }
            }

            return bm;
        }

        // Solve the problem and draw the chess board.
        private void solveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            NumRows = int.Parse(numRowsTextBox.Text);
            NumCols = int.Parse(numColsTextBox.Text);
            NumSquares = NumRows * NumCols;
            MoveNumber = new int[NumRows, NumCols];

            boardPictureBox.Image = MakeClearBoard();
            Refresh();

            long numAttempts = 0;
            DateTime startTime = DateTime.Now;

            // Try starting from [0, 0].
            bool success = KnightsTour(0, 0, MoveNumber, 0, ref numAttempts);
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

        // Move the knight to position [row, col]. Then recursively try
        // to make other moves. Return true if we find a valid solution.
        private bool KnightsTour(int row, int col, int[,] moveNumber, int numMovesTaken, ref long numAttempts)
        {
            // Move the knight to this position.
            numAttempts++;
            numMovesTaken++;
            moveNumber[row, col] = numMovesTaken;

            // See if we have taken all of the required moves.
            if (numMovesTaken == NumSquares) return true;

            // Build arrays to determine where legal moves are
            // with respect to this position.
            int[] dRows = { -2, -2, -1, 1, 2, 2, 1, -1 };
            int[] dCols = { -1, 1, 2, 2, 1, -1, -2, -2 };

            // Try all legal positions for the next move.
            for (int i = 0; i < dRows.Length; i++)
            {
                int r = row + dRows[i];
                int c = col + dCols[i];
                if ((r >= 0) && (r < NumRows) &&
                    (c >= 0) && (c < NumCols) &&
                    (moveNumber[r, c] == 0))
                {
                    // This move is legal and available. Make this move
                    // and then recursively try other assignments.
                    if (KnightsTour(r, c, moveNumber, numMovesTaken, ref numAttempts))
                        return true;
                }
            }

            // This move didn't work out. Undo it.
            moveNumber[row, col] = 0;

            // If we get here, we did not find a valid solution.
            return false;
        }
    }
}
