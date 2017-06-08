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

namespace AddSmaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate AddSmaller recursively.
        private void recursiveButton_Click(object sender, EventArgs e)
        {
            recursiveResultTextBox.Clear();
            recursiveTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            int n = int.Parse(nTextBox.Text);
            long result = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            result = RecursiveAddSmaller(n);
            watch.Stop();

            recursiveResultTextBox.Text = result.ToString();
            recursiveTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");

            Cursor = Cursors.Default;
        }
        private long RecursiveAddSmaller(int n)
        {
            if (n == 0) return 0;
            return n + RecursiveAddSmaller(n - 1);
        }

        // Calculate AddSmaller non-recursively.
        private void nonrecursiveButton_Click(object sender, EventArgs e)
        {
            nonrecursiveResultTextBox.Clear();
            nonrecursiveTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            int n = int.Parse(nTextBox.Text);
            long result = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            result = NonrecursiveAddSmaller(n);
            watch.Stop();

            nonrecursiveResultTextBox.Text = result.ToString();
            nonrecursiveTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");

            Cursor = Cursors.Default;
        }
        private long NonrecursiveAddSmaller(int n)
        {
            long result = 0;
            while (n > 0)
            {
                result = result + n;
                n = n - 1;
            }
            return result;
        }

        // Clear previous results.
        private void nTextBox_TextChanged(object sender, EventArgs e)
        {
            recursiveResultTextBox.Clear();
            recursiveTimeTextBox.Clear();
            nonrecursiveResultTextBox.Clear();
            nonrecursiveTimeTextBox.Clear();
        }
    }
}
