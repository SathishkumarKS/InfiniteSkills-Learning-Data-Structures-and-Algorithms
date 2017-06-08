using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The queue.
        private LinkedListQueue<string> TheQueue = new LinkedListQueue<string>();

        // Add a value to the queue.
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            TheQueue.Enqueue(valueTextBox.Text);
            valueTextBox.Clear();
            valueTextBox.Focus();
            ShowQueue();
        }

        // Remove a value from the queue.
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
            for (QueueCell<string> cell = TheQueue.TopSentinel.Next;
                cell != TheQueue.BottomSentinel; cell = cell.Next)
            {
                itemsListBox.Items.Add(cell.Value);
            }
        }
    }
}
