// #define CHECK_RESULTS

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

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The values.
        private long[] Values = null;
        private int MinValue, MaxValue;
        private Random Rand = new Random();

        private void createButton_Click(object sender, EventArgs e)
        {
            int numItems = int.Parse(numItemsTextBox.Text);
            int minStep = int.Parse(minStepTextBox.Text);
            int maxStep = int.Parse(maxStepTextBox.Text);
            Values = new long[numItems];
            int value = 0;
            for (int i = 0; i < numItems; i++)
            {
                Values[i] = value;
                value += Rand.Next(minStep, maxStep + 1);
            }
            MinValue = (int)Values.Min();
            MaxValue = (int)Values.Max();

            ClearResults();
            searchButton.Enabled = true;
        }

        // Clear previous results.
        private void ClearResults()
        {
            linearTextBox.Clear();
            binaryTextBox.Clear();
            interpolationTextBox.Clear();
            interpolation2TextBox.Clear();
        }

        // Perform the searches.
        private void searchButton_Click(object sender, EventArgs e)
        {
            ClearResults();
            Cursor = Cursors.WaitCursor;
            Refresh();

            double maxTime = double.Parse(maxTimeTextBox.Text);

            // Linear search.
            RunAlgorithm(Searchers<long>.LinearSearch, maxTime, linearTextBox);

            // Binary search.
            RunAlgorithm(Searchers<long>.BinarySearch, maxTime, binaryTextBox);

            // Interpolation search.
            RunAlgorithm(Searchers<long>.InterpolationSearch, maxTime, interpolationTextBox);

            // Interpolation search 2.
            RunAlgorithm(Searchers<long>.InterpolationSearch2, maxTime, interpolation2TextBox);

            Cursor = Cursors.Default;
        }

        public delegate int Algorithm(long[] values, long target);
        private void RunAlgorithm(Algorithm alg, double maxTime, TextBox timeTextBox)
        {
            Stopwatch watch = new Stopwatch();
            int numTrials = 0;
            watch.Start();
            while (watch.Elapsed.TotalSeconds < maxTime)
            {
                numTrials++;
                long target = (long)Rand.Next(MinValue, MaxValue + 1);
                int index = alg(Values, target);

#if CHECK_RESULTS
                if (index >= 0) Debug.Assert(Values[index] == target);
                else Debug.Assert(!Values.Contains(target));
#endif

            }
            watch.Stop();

            // Display the elapsed time.
            double msPerRun = watch.Elapsed.TotalSeconds / numTrials * 1000000.0;
            timeTextBox.Text = msPerRun.ToString("0.00");
            timeTextBox.Refresh();
        }

        // One of the list parameters changed.
        private void parameter_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = false;
            ClearResults();
        }
    }
}
