using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The stack.
        private Stack<string> TheStack = new Stack<string>(10);

        // Push a value onto the stack.
        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
                TheStack.Push(valueTextBox.Text);
                valueTextBox.Clear();
                valueTextBox.Focus();
                ShowStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Pop a value off of the stack.
        private void popButton_Click(object sender, EventArgs e)
        {
            try
            {
                valueTextBox.Text = TheStack.Pop();
                valueTextBox.Focus();
                ShowStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Show the stack's values.
        private void ShowStack()
        {
            itemsListBox.Items.Clear();
            for (int i = TheStack.NextSpot - 1; i >= 0; i--)
            {
                itemsListBox.Items.Add(TheStack.Values[i]);
            }
        }
    }
}
