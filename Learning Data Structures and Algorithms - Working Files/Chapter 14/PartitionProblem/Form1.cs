using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace PartitionProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The values.
        private int[] Values;

        // The best solution found.
        private int[] Solution;

        // The best difference found.
        private int BestDifference;

        // Make random values.
        private void makeValuesButton_Click(object sender, EventArgs e)
        {
            int numValues = int.Parse(numValuesTextBox.Text);
            int min = int.Parse(minimumTextBox.Text);
            int max = int.Parse(maximumTextBox.Text);
            Values = new int[numValues];
            Solution = new int[numValues];

            //Random rand = new Random(104);  // This seed makes 20 values with no perfect solution.
            Random rand = new Random();

            for (int i = 0; i < numValues; i++)
                Values[i] = rand.Next(min, max + 1);
            valuesListBox.DataSource = Values;

            ClearResults();
            exhaustiveButton.Enabled = true;
            branchAndBoundButton.Enabled = true;
            randWithSwapsButton.Enabled = true;
            randomButton.Enabled = true;
            greedyButton.Enabled = true;
            sortedGreedyButton.Enabled = true;
        }

        // Search for a solution exhaustively.
        private void exhaustiveButton_Click(object sender, EventArgs e)
        {
            exhaustiveTimeTextBox.Clear();
            exhaustiveDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.ExhaustiveSearch(Values, Solution, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, exhaustiveTimeTextBox, exhaustiveDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Search for a solution with branch and bound.
        private void branchAndBoundButton_Click(object sender, EventArgs e)
        {
            branchAndBoundTimeTextBox.Clear();
            branchAndBoundDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.BranchAndBound(Values, Solution, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, branchAndBoundTimeTextBox, branchAndBoundDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Try random solutions.
        private void randomButton_Click(object sender, EventArgs e)
        {
            randomTimeTextBox.Clear();
            randomDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            int N = Values.Length;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.Random(Values, Solution, N * N, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, randomTimeTextBox, randomDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Search for a solution with random solutions and pair swaps.
        private void randWithSwapsButton_Click(object sender, EventArgs e)
        {
            randWithSwapsTimeTextBox.Clear();
            randWithSwapsDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            int N = Values.Length;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.RandomWithSwaps(Values, Solution, N * N, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, randWithSwapsTimeTextBox, randWithSwapsDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Search for a solution with a simple greedy algorithm.
        private void greedyButton_Click(object sender, EventArgs e)
        {
            greedyTimeTextBox.Clear();
            greedyDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.Greedy(Values, Solution, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, greedyTimeTextBox, greedyDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Search for a solution with a sorted greedy algorithm.
        private void sortedGreedyButton_Click(object sender, EventArgs e)
        {
            sortedGreedyTimeTextBox.Clear();
            sortedGreedyDiffTextBox.Clear();
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            Cursor = Cursors.WaitCursor;
            Refresh();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Partitions.SortedGreedy(Values, Solution, out BestDifference);
            watch.Stop();
            ShowSolution(watch.Elapsed.TotalSeconds, sortedGreedyTimeTextBox, sortedGreedyDiffTextBox);

            Cursor = Cursors.Default;
        }

        // Display the solution.
        private void ShowSolution(double seconds, TextBox timeTextBox, TextBox diffTextBox)
        {
            List<int>[] sets = { new List<int>(), new List<int>() };
            for (int i = 0; i < Values.Length; i++)
                sets[Solution[i]].Add(Values[i]);
            set0ListBox.DataSource = sets[0];
            set1ListBox.DataSource = sets[1];

            timeTextBox.Text = seconds.ToString("0.00");
            diffTextBox.Text = BestDifference.ToString();

            total0TextBox.Text = "Total: " + sets[0].Sum().ToString();
            total1TextBox.Text = "Total: " + sets[1].Sum().ToString();
        }

        // Clear previous results.
        private void ClearResults()
        {
            set0ListBox.DataSource = null;
            set1ListBox.DataSource = null;
            total0TextBox.Clear();
            total1TextBox.Clear();

            exhaustiveTimeTextBox.Clear();
            exhaustiveDiffTextBox.Clear();
            branchAndBoundTimeTextBox.Clear();
            branchAndBoundDiffTextBox.Clear();
            randWithSwapsTimeTextBox.Clear();
            randWithSwapsDiffTextBox.Clear();
            randomTimeTextBox.Clear();
            randomDiffTextBox.Clear();
            greedyTimeTextBox.Clear();
            greedyDiffTextBox.Clear();
            sortedGreedyTimeTextBox.Clear();
            sortedGreedyDiffTextBox.Clear();
        }

        // The value generation parameters have changed.
        private void parameters_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
            exhaustiveButton.Enabled = false;
            branchAndBoundButton.Enabled = false;
            randWithSwapsButton.Enabled = false;
            randomButton.Enabled = false;
            greedyButton.Enabled = false;
            sortedGreedyButton.Enabled = false;
        }
    }
}
