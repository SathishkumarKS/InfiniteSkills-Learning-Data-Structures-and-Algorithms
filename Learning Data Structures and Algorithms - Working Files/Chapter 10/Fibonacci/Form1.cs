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

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The table to hold calculated values.
        private long[] FibValues = new long[10000];

        // Initialize the table for Fib(0) and Fib(1).
        private void Form1_Load(object sender, EventArgs e)
        {
            FibValues[0] = 1;
            FibValues[1] = 1;
        }

        // Calculate the Fibonacci number recursively.
        // Works up to around Fib(37) or Fib(40) before it takes a really long time.
        private void recursiveButton_Click(object sender, EventArgs e)
        {
            recursiveResultTextBox.Clear();
            recursiveTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            try
            {
                int n = int.Parse(nTextBox.Text);
                if (n > 40)
                {
                    if (MessageBox.Show("This may take a while. Continue anyway?",
                        "Continue?", MessageBoxButtons.YesNo)
                            == DialogResult.No)
                        return;
                }

                long result = 0;
                Stopwatch watch = new Stopwatch();
                watch.Start();
                result = RecursiveFibonacci(n);
                watch.Stop();

                recursiveResultTextBox.Text = result.ToString();
                recursiveTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private long RecursiveFibonacci(int n)
        {
            if (n <= 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        // Calculate the Fibonacci number with a table.
        // Works up to Fib(5465).
        private void tableButton_Click(object sender, EventArgs e)
        {
            tableResultTextBox.Clear();
            tableTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            try
            {
                int n = int.Parse(nTextBox.Text);
                long result = 0;
                Stopwatch watch = new Stopwatch();
                watch.Start();
                result = TableFibonacci(n);
                watch.Stop();

                tableResultTextBox.Text = result.ToString();
                tableTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor = Cursors.Default;
        }
        private long TableFibonacci(int n)
        {
            if (FibValues[n] == 0)
                FibValues[n] = checked(TableFibonacci(n - 1) + TableFibonacci(n - 2));
            return FibValues[n];
        }

        // Calculate the Fibonacci number iteratvely.
        // Works up to Fib(5465).
        private void iterativeButton_Click(object sender, EventArgs e)
        {
            iterativeResultTextBox.Clear();
            iterativeTimeTextBox.Clear();
            Cursor = Cursors.WaitCursor;
            Refresh();

            try
            {
                int n = int.Parse(nTextBox.Text);
                long result = 0;
                Stopwatch watch = new Stopwatch();
                watch.Start();
                result = IterativeFibonacci(n);
                watch.Stop();

                iterativeResultTextBox.Text = result.ToString();
                iterativeTimeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.000000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor = Cursors.Default;
        }
        private long IterativeFibonacci(int n)
        {
            if (n <= 1) return 1;

            long fib_i_1 = 1;   // Fib(1)
            long fib_i_2 = 1;   // Fib(0)
            long fib = 0;
            for (int i = 2; i <= n; i++)
            {
                fib = checked(fib_i_1 + fib_i_2);
                fib_i_2 = fib_i_1;
                fib_i_1 = fib;
            }

            return fib;
        }

        // Clear previous results.
        private void nTextBox_TextChanged(object sender, EventArgs e)
        {
            recursiveResultTextBox.Clear();
            recursiveTimeTextBox.Clear();
            tableResultTextBox.Clear();
            tableTimeTextBox.Clear();
            iterativeResultTextBox.Clear();
            iterativeTimeTextBox.Clear();
        }
    }
}
