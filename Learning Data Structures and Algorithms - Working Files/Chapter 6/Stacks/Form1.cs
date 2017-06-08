using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The stack.
        private Stack<string> TheStack = new Stack<string>();

        // Push a value onto the stack.
        private void pushButton_Click(object sender, EventArgs e)
        {
            TheStack.Push(valueTextBox.Text);
            valueTextBox.Clear();
            valueTextBox.Focus();
            ShowStack();
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
            for (StackCell<string> cell = TheStack.Top; cell != null; cell = cell.Next)
            {
                itemsListBox.Items.Add(cell.Value);
            }
        }
    }
}
