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

namespace KnightsTour2
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

        // Legal moves for each square.
        private List<Point>[,] LegalMoves;

        // Draw the blank chess board.
        private void Form1_Load(object sender, EventArgs e)
        {
            NumRows = int.Parse(numRowsTextBox.Text);
            NumCols = int.Parse(numColsTextBox.Text);
            NumSquares = NumRows * NumCols;
            MoveNumber = new int[NumRows, NumCols];

            boardPictureBox.Image = MakeClearBoard();
        }

        // For each square, build a list giving legal moves from that position.
        private void MakeLegalMoves()
        {
            LegalMoves = new List<Point>[NumRows, NumCols];

            // Possible moves.
            int[] dRows = { -2, -2, -1, 1, 2, 2, 1, -1 };
            int[] dCols = { -1, 1, 2, 2, 1, -1, -2, -2 };

            for (int row = 0; row < NumRows; row++)
            {
                for (int col = 0; col < NumCols; col++)
                {
                    LegalMoves[row, col] = new List<Point>();

                    for (int i = 0; i < dRows.Length; i++)
                    {
                        int r = row + dRows[i];
                        int c = col + dCols[i];
                        if ((r >= 0) && (r < NumRows) &&
                            (c >= 0) && (c < NumCols))
                        {
                            // This move is legal.
                            LegalMoves[row, col].Add(new Point(r, c));
                        }
                    }
                }
            }

            //// Sort the lists by increasing number of possible moves.
            //for (int row = 0; row < NumRows; row++)
            //{
            //    for (int col = 0; col < NumCols; col++)
            //    {
            //        // Sort this square's legal moves.
            //        List<Point> moves = new List<Point>();
            //        while (LegalMoves[row, col].Count > 0)
            //        {
            //            // Find the move with the smallest number of next possible moves.
            //            Point bestMove = LegalMoves[row, col][0];
            //            int bestNumMoves = LegalMoves[bestMove.X, bestMove.Y].Count;
            //            for (int i = 1; i < LegalMoves[row, col].Count; i++)
            //            {
            //                Point testMove = LegalMoves[row, col][0];
            //                int testNumMoves = LegalMoves[testMove.X, testMove.Y].Count;
            //                if (testNumMoves < bestNumMoves)
            //                {
            //                    bestNumMoves = testNumMoves;
            //                    bestMove = testMove;
            //                }
            //            }

            //            // Move the best move to the new list.
            //            moves.Add(bestMove);
            //            LegalMoves[row, col].Remove(bestMove);
            //        }

            //        // Save the new list of moves.
            //        LegalMoves[row, col] = moves;
            //    }
            //}
        }

        // Return the number of possible moves from a square.
        private int NumMoves(int row, int col)
        {
            int result = 0;
            foreach (Point move in LegalMoves[row, col])
            {
                if (MoveNumber[move.X, move.Y] == 0) result++;
            }
            return result;
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

            // Make the lists of legal moves.
            MakeLegalMoves();

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

        // Move the knght to position [row, col]. Then recursively try to make other moves.
        // Return true if we find a valid solution.
        private bool KnightsTour(int row, int col, int[,] moveNumber, int numMovesTaken, ref long numAttempts)
        {
            // Move the knight to this position.
            numAttempts++;
            numMovesTaken++;
            moveNumber[row, col] = numMovesTaken;

            // See if we have taken all of the required moves.
            if (numMovesTaken == NumSquares) return true;

            // Make a copy of the legal moves that are not yet taken.
            List<Point> moves = new List<Point>();
            foreach (Point move in LegalMoves[row, col])
            {
                if (moveNumber[move.X, move.Y] == 0) moves.Add(move);
            }

            // Try all legal positions for the next move.
            // Try them in the order given by Warnsdorff's heuristic.
            while (moves.Count > 0)
            {
                // Find the move with the least number of next moves.
                Point bestMove = moves[0];
                int bestCount = NumMoves(bestMove.X, bestMove.Y);
                foreach (Point move in moves)
                {
                    int testCount = NumMoves(move.X, move.Y);
                    if (bestCount > testCount)
                    {
                        bestCount = testCount;
                        bestMove = move;
                    }
                }

                // Use the best move.
                moves.Remove(bestMove);

                // Use the best move and recursively try other assignments.
                if (KnightsTour(bestMove.X, bestMove.Y, moveNumber, numMovesTaken, ref numAttempts))
                    return true;
            }

            // This move didn't work out. Undo it.
            moveNumber[row, col] = 0;

            // If we get here, we did not find a valid solution.
            return false;
        }
    }
}
