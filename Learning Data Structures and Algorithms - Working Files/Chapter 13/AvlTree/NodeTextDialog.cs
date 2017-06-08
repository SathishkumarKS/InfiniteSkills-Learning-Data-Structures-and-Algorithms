using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvlTree
{
    public partial class NodeTextDialog : Form
    {
        public NodeTextDialog()
        {
            InitializeComponent();
        }

        // Replace Show so the program cannot use it.
        public new void Show()
        {
            throw new InvalidOperationException(
                "Use ShowDialog not Show to display this dialog");
        }
    }
}
