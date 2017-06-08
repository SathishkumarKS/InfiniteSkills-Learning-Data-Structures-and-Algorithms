using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            int numDisks = (int)numDisksNumericUpDown.Value;
            resultTextBox.Text = TowerOfHanoi("A", "B", "C", numDisks);
        }

        // Move the top numDisks disks from peg fromPeg to peg toPeg
        // using otherPeg to hold disks temporarily as needed.
        private string TowerOfHanoi(string fromPeg, string toPeg, string otherPeg, int numDisks)
        {
            string result = "";

            // Recursively move the top n - 1 disks from from_peg to other_peg.
            if (numDisks > 1)
                result += TowerOfHanoi(fromPeg, otherPeg, toPeg, numDisks - 1);

            // Move the last disk from from_peg to to_peg.
            if (numDisks > 1) result += " ";
            result += fromPeg + "->" + toPeg;

            // Recursively move the top n - 1 disks back from other_peg to to_peg.
            if (numDisks > 1)
                result += " " + TowerOfHanoi(otherPeg, toPeg, fromPeg, numDisks - 1);

            return result;
        }
    }
}
