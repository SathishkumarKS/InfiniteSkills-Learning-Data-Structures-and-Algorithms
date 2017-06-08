using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The queue.
        private CircularQueue<string> TheQueue = new CircularQueue<string>(10);

        // Add a value to the queue.
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            try
            {
                TheQueue.Enqueue(valueTextBox.Text);
                valueTextBox.Clear();
                valueTextBox.Focus();
                ShowQueue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            try
            {
                valueTextBox.Text = TheQueue.Dequeue();
                valueTextBox.Focus();
                ShowQueue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Show the queue's values.
        private void ShowQueue()
        {
            itemsListBox.Items.Clear();
            for (int i = 0; i < TheQueue.Count; i++)
            {
                int index = (TheQueue.Bottom + i) % TheQueue.Values.Length;
                itemsListBox.Items.Add(TheQueue.Values[index]);
            }
        }
    }
}
