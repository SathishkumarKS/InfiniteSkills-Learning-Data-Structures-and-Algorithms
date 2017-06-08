using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleStacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The stack.
        private DoubleStack<string> TheStack = new DoubleStack<string>(10);

        // Push an item onto the top of the left stack.
        private void pushLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                TheStack.PushLeft(valueTextBox.Text);
                valueTextBox.Clear();
                valueTextBox.Focus();
                ShowStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Push an item onto the top of the right stack.
        private void pushRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                TheStack.PushRight(valueTextBox.Text);
                valueTextBox.Clear();
                valueTextBox.Focus();
                ShowStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Pop a value off of the left stack.
        private void popLeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                valueTextBox.Text = TheStack.PopLeft();
                valueTextBox.Focus();
                ShowStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Pop a value off of the right stack.
        private void popRightButton_Click(object sender, EventArgs e)
        {
            try
            {
                valueTextBox.Text = TheStack.PopRight();
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
            leftItemsListBox.Items.Clear();
            for (int i = TheStack.NextLeft - 1; i >= 0; i--)
            {
                leftItemsListBox.Items.Add(TheStack.Values[i]);
            }

            rightItemsListBox.Items.Clear();
            for (int i = TheStack.NextRight + 1; i < TheStack.Values.Length; i++)
            {
                rightItemsListBox.Items.Add(TheStack.Values[i]);
            }
        }
    }
}
