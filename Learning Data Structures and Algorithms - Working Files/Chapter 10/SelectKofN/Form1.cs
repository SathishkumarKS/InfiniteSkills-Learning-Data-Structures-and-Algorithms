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

namespace SelectKofN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Select the items.
        private void goButton_Click(object sender, EventArgs e)
        {
            int k = (int)kNumericUpDown.Value;
            int n = (int)nNumericUpDown.Value;
            if (k > n)
            {
                MessageBox.Show("The number of items to select must be no greater than the total number of items.");
                return;
            }

            // Make the list of items.
            int ascA = (int)'A';
            List<string> items = new List<string>();
            for (int i = 0; i < n; i++)
                items.Add(((char)(ascA + i)).ToString());

            int[] selections = new int[k];
            List<string> results = new List<string>();

            SelectKofNwithDuplicates(0, selections, items, results);
            withDuplicatesListBox.DataSource = results;
            withDuplicatesLabel.Text = withDuplicatesListBox.Items.Count.ToString() + " combinations";

            results = new List<string>();
            SelectKofNwithoutDuplicates(0, selections, items, results);
            withoutDuplicatesListBox.DataSource = results;
            withoutDuplicatesLabel.Text = withoutDuplicatesListBox.Items.Count.ToString() + " combinations";

            // Verify the counts with calculations.
            Debug.Assert(withDuplicatesListBox.Items.Count == Choose(n + k - 1, k));
            Debug.Assert(withoutDuplicatesListBox.Items.Count == Choose(n, k));
        }

        // Generate combinations allowing duplicates.
        private void SelectKofNwithDuplicates(int index, int[] selections, List<string> items, List<string> results)
        {
            // See if we have made the last assignment.
            if (index == selections.Length)
            {
                // Add the result to the result list.
                string result = "";
                for (int i = 0; i < selections.Length; i++)
                    result += items[selections[i]];
                results.Add(result);
            }
            else
            {
                // Get the smallest value we can use for the next selection.
                int start = 0;
                if (index > 0) start = selections[index - 1];

                // Make the next assignment.
                for (int i = start; i < items.Count; i++)
                {
                    // Add item i to the selection.
                    selections[index] = i;

                    // Recursively make the other assignments.
                    SelectKofNwithDuplicates(index + 1, selections, items, results);
                }
            }
        }

        // Generate combinations not allowing duplicates.
        private void SelectKofNwithoutDuplicates(int index, int[] selections, List<string> items, List<string> results)
        {
            // See if we have made the last assignment.
            if (index == selections.Length)
            {
                // Add the result so far to the result list.
                string result = "";
                for (int i = 0; i < selections.Length; i++)
                    result += items[selections[i]];
                results.Add(result);
            }
            else
            {
                // Get the smallest value we can use for the next selection.
                int start = 0;
                if (index > 0) start = selections[index - 1] + 1;

                // Make the next assignment.
                for (int i = start; i < items.Count; i++)
                {
                    // Add item i to the selection.
                    selections[index] = i;

                    // Recursively make the other assignments.
                    SelectKofNwithoutDuplicates(index + 1, selections, items, results);
                }
            }
        }

        private long Choose(long m, long n)
        {
            return Factorial(m) / Factorial(n) / Factorial(m - n);
        }
        private long Factorial(long n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }
    }
}
