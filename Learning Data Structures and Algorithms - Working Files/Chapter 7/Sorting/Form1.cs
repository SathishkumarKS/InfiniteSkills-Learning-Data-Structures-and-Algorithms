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

// Notes:
// - When you run the algorithms, the program repeats each algorithm until the
//   total time is greater than the value you entered in the Secs/Alg box.
//   It then divides the total time by the number of trials it performed to get
//   time per trial.
// - If you check the # Unsorted box, the program sorts the random values.
//   It then takes the number you entered in that text box, divides by 2,
//   and makes that many random swaps. For example, if you enter 10, it swaps 5
//   random pairs of values. That gives the array roughly 10 values that are
//   out of their sorted positions.

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Used to generate unsorted values.
        private Random Rand = new Random();

        // The unsorted values.
        private int[] UnsortedValues;
        private int MinValue, MaxValue;

        // The sorted values.
        private int[] SortedValues;

        // True if SortedValues was sorted by some algorithm.
        private bool Sorted = false;

        // Generate unsorted values.
        private void generateButton_Click(object sender, EventArgs e)
        {
            // Generate the unsorted values.
            int numValues = int.Parse(numValuesTextBox.Text);
            UnsortedValues = new int[numValues];
            MinValue = int.Parse(minimumTextBox.Text);
            MaxValue = int.Parse(maximumTextBox.Text);
            for (int i = 0; i < numValues; i++)
                UnsortedValues[i] = Rand.Next(MinValue, MaxValue + 1);

            // See if we should initially sort them.
            if (numUnsortedCheckBox.Checked)
            {
                // Sort the values.
                Array.Sort(UnsortedValues);

                // Swap some values out of position.
                int numUnsorted = int.Parse(numUnsortedTextBox.Text) / 2;
                for (int i = 0; i < numUnsorted; i++)
                {
                    int j = Rand.Next(0, UnsortedValues.Length);
                    int k = Rand.Next(0, UnsortedValues.Length);
                    int temp = UnsortedValues[j];
                    UnsortedValues[j] = UnsortedValues[k];
                    UnsortedValues[k] = temp;
                }
            }

            // Display up to 1,000 unsorted values.
            unsortedListBox.DataSource = UnsortedValues.Take(1000).ToArray();

            // Clear the sorted ListBox.
            sortedListBox.DataSource = null;

            // Enable the Run button.
            runButton.Enabled = true;
        }

        // Run the selected sorting algorithms.
        private void runButton_Click(object sender, EventArgs e)
        {
            // Clear previous results.
            Sorted = false;
            ClearResults();
            Cursor = Cursors.WaitCursor;
            Refresh();

            float maxSeconds = float.Parse(secsPerAlgTextBox.Text);
            SortedValues = new int[UnsortedValues.Length];

            // Insertionsort.
            if (insertionsortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Insertionsort, insertionsortTextBox);

            // Selectionsort.
            if (selectionsortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Selectionsort, selectionsortTextBox);

            // Quicksort.
            if (quicksortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Quicksort, quicksortTextBox);

            // Heapsort.
            if (heapsortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Heapsort, heapsortTextBox);

            // Mergesort.
            if (mergesortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Mergesort, mergesortTextBox);

            // Mergesort2.
            if (mergesort2CheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Mergesort2, mergesort2TextBox);

            // Bubblesort.
            if (bubblesortCheckBox.Checked)
                RunAlgorithm(maxSeconds, Sorts<int>.Bubblesort, bubblesortTextBox);

            // Bubblesort2.
            if (bubblesort2CheckBox.Checked) 
                RunAlgorithm(maxSeconds, Sorts<int>.Bubblesort2, bubblesort2TextBox);

            // Countingsort.
            if (countingsortCheckBox.Checked)
            {
                RunAlgorithm(maxSeconds, RunCountingsort, countingsortTextBox);
            }

            // Display up to 1,000 sorted values.
            if (Sorted) sortedListBox.DataSource = SortedValues.Take(1000).ToArray();
            Cursor = Cursors.Default;
        }

        // Run the countingsort algorithm.
        private void RunCountingsort(int[] values)
        {
            CountingSorts.Countingsort(values, MinValue, MaxValue);
        }

        // Run an algorithm. Return the number of microseconds per trial.
        private delegate void Algorithm(int[] values);
        private void RunAlgorithm(double maxSeconds, Algorithm alg, TextBox timeTextBox)
        {
            Sorted = true;
            Stopwatch watch = new Stopwatch();
            int numTrials = 0;
            for (; ; )
            {
                numTrials++;

                // Make a copy of the unsorted values.
                UnsortedValues.CopyTo(SortedValues, 0);

                // Execute the algorithm.
                watch.Start();
                alg(SortedValues);
                watch.Stop();

                // See if we've spent long enough on this algorithm.
                if (watch.Elapsed.TotalSeconds > maxSeconds) break;
            }

            // Display the elapsed time.
            double msPerRun = watch.Elapsed.TotalSeconds / numTrials * 1000000.0;
            timeTextBox.Text = msPerRun.ToString("0.00");
            timeTextBox.Refresh();

            // Verify.
            for (int i = 1; i < SortedValues.Length; i++)
                Debug.Assert(SortedValues[i - 1] <= SortedValues[i]);
        }

        // One of the value parameters changed.
        // Make the user generate new values before sorting.
        private void parameterTextBox_TextChanged(object sender, EventArgs e)
        {
            ParametersChanged();
        }
        private void ParametersChanged()
        {
            runButton.Enabled = false;
            unsortedListBox.DataSource = null;
            ClearResults();
        }

        // Clear the elapsed time TextBoxes.
        private void ClearResults()
        {
            sortedListBox.DataSource = null;

            insertionsortTextBox.Clear();
            selectionsortTextBox.Clear();
            quicksortTextBox.Clear();
            heapsortTextBox.Clear();
            mergesortTextBox.Clear();
            mergesort2TextBox.Clear();
            bubblesortTextBox.Clear();
            bubblesort2TextBox.Clear();
            countingsortTextBox.Clear();
        }

        // Enabled or disable the # Unsorted TextBox.
        private void numUnsortedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numUnsortedTextBox.Enabled = numUnsortedCheckBox.Checked;
            ParametersChanged();
        }
    }
}
