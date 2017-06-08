#define USE_COLOR

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Media;
using System.IO;

namespace NetworkMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The currently loaded network.
        private Network TheNetwork = new Network();

        // The cursors to use while making a new link.
        private Cursor AddLinkCursor;

        // What the user is doing on the PictureBox.
        private enum Modes
        {
            None,
            AddNode,
            AddLink1,
            AddLink2,
            DFTraversal,
            BFTraversal,
            SpanningTree,
            MinimalSpanningTree,
            AnyPath,
            LabelSettingTree,
            LabelSettingPath,
            LabelCorrectingTree,
            LabelCorrectingPath,
        }
        private Modes Mode = Modes.None;

        // Tool strip buttons that toggle.
        private List<ToolStripButton> ToggleButtons = new List<ToolStripButton>();

        // Load the add link cursors.
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

            AddLinkCursor = new Cursor(new MemoryStream(Properties.Resources.AddLink1));

            ToggleButtons.Add(addNodeToolStripButton);
            ToggleButtons.Add(addLinkToolStripButton);
            ToggleButtons.Add(addLink2ToolStripButton);

            ToggleButtons.Add(dfTraverseToolStripButton);
            ToggleButtons.Add(bfTraverseToolStripButton);
            ToggleButtons.Add(spanningTreeToolStripButton);
            ToggleButtons.Add(minimalSpanningTreeToolStripButton);
            ToggleButtons.Add(anyPathToolStripButton);
            ToggleButtons.Add(labelSettingTreeToolStripButton);
            ToggleButtons.Add(labelSettingPathToolStripButton);
            ToggleButtons.Add(labelCorrectingTreeToolStripButton);
            ToggleButtons.Add(labelCorrectingPathToolStripButton);

            foreach (ToolStripButton button in ToggleButtons)
                button.CheckOnClick = true;
        }

        // Exit.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load a network file.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the network;
                    Network network = Network.LoadNetwork(openFileDialog1.FileName);

                    // Start using the new network.
                    TheNetwork = network;

                    // Draw the new network.
                    networkPictureBox.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Save the network in a file.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save the network.
                    TheNetwork.SaveNetwork(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Draw the network.
        private void networkPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(networkPictureBox.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

#if USE_COLOR
            using (Pen pen = new Pen(Color.Red, 3))
#else
            using (Pen pen = new Pen(Color.Black, 3))
#endif
            {
                using (Font nodeFont = new Font("Times New Roman", 14))
                {
                    using (Font linkFont = new Font("Times New Roman", 10, FontStyle.Bold))
                    {
#if USE_COLOR
                        TheNetwork.Draw(
                            showNodeTextToolStripMenuItem.Checked,
                            showLinkCostsToolStripMenuItem.Checked,
                            showLinkCapacitiesToolStripMenuItem.Checked,
                            e.Graphics, nodeFont, linkFont,
                            Pens.Blue, Brushes.Black, Pens.Black, Brushes.White, Brushes.Black,
                            pen, Brushes.Red, Pens.White, Brushes.Black, Brushes.White);
#else
                        TheNetwork.Draw(
                            showNodeTextToolStripMenuItem.Checked,
                            showLinkCostsToolStripMenuItem.Checked,
                            showLinkCapacitiesToolStripMenuItem.Checked,
                            e.Graphics, nodeFont, linkFont,
                            Pens.Gray, Brushes.Black, Pens.Black, Brushes.White, Brushes.Black,
                            pen, Brushes.Gray, Pens.White, Brushes.Black, Brushes.White);
#endif
                    }
                }
            }
        }

        // The nodes selected by the user while adding a link or finding a path.
        private NetworkNode Node0 = null, Node1 = null;

        // Add a node or link if appropriate.
        private void networkPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mode == Modes.AddNode)
            {
                // Add a node.
                NetworkNode node = new NetworkNode();
                node.Location = e.Location;
                node.Index = TheNetwork.AllNodes.Count;
                node.Name = NumberToLetters(node.Index);
                TheNetwork.AllNodes.Add(node);
                networkPictureBox.Refresh();
            }
            else if (
                (Mode == Modes.AddLink1) ||
                (Mode == Modes.AddLink2))
            {
                // Add a link.
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    if (e.Button == MouseButtons.Left) Node0 = node;
                    else Node1 = node;

                    // See if we have both nodes.
                    if ((Node0 != null) && (Node1 != null))
                    {
                        // Make the link.
                        if (Mode == Modes.AddLink1) TheNetwork.MakeLink(Node0, Node1);
                        else TheNetwork.MakeLinks(Node0, Node1);

                        // We're done with this link.
                        Node0 = null;
                        Node1 = null;

                        // Redraw.
                        networkPictureBox.Refresh();
                    }
                }
            }
            else if (Mode == Modes.DFTraversal)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Traverse the network.
                    bool isConnected;
                    List<NetworkNode> traversal =
                        TheNetwork.DepthFirstTraverse(node, out isConnected);

                    // Display the traversal.
                    string txt = "";
                    foreach (NetworkNode traversalNode in traversal)
                        txt += " " + traversalNode.ToString();
                    toolStripStatusLabel1.Text = "Traversal: " + txt;
                    if (isConnected) txt += " Connected.";
                    else txt += " Not connected.";
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.BFTraversal)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Traverse the network.
                    bool isConnected;
                    List<NetworkNode> traversal =
                        TheNetwork.BreadthFirstTraverse(node, out isConnected);

                    // Display the traversal.
                    string txt = "";
                    foreach (NetworkNode traversalNode in traversal)
                        txt += " " + traversalNode.ToString();
                    toolStripStatusLabel1.Text = "Traversal: " + txt;
                    if (isConnected) txt += " Connected.";
                    else txt += " Not connected.";
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.SpanningTree)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Build a spanning tree.
                    bool isConnected;
                    float cost = TheNetwork.MakeSpanningTree(node, out isConnected);
                    toolStripStatusLabel1.Text = "Total cost: " + cost.ToString();
                    string txt;
                    if (isConnected) txt = "Connected. ";
                    else txt = "Not connected. ";
                    txt += "Total cost: " + cost.ToString();
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.MinimalSpanningTree)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Build a spanning tree.
                    bool isConnected;
                    float cost = TheNetwork.MakeMinimalSpanningTree(node, out isConnected);
                    string txt;
                    if (isConnected) txt = "Connected. ";
                    else txt = "Not connected. ";
                    txt += "Total cost: " + cost.ToString();
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.AnyPath)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    if (e.Button == MouseButtons.Left) Node0 = node;
                    else Node1 = node;

                    // See if we have both nodes.
                    if ((Node0 != null) && (Node1 != null))
                    {
                        // Find a path between the nodes.
                        List<NetworkNode> pathNodes;
                        List<NetworkLink> pathLinks;
                        int cost = TheNetwork.FindAnyPath(Node0, Node1,
                            out pathNodes, out pathLinks);

                        string txt = "Path: ";
                        foreach (NetworkNode pathNode in pathNodes)
                            txt += pathNode.Name + " ";
                        txt += "Total cost: " + cost.ToString();
                        toolStripStatusLabel1.Text = txt;
                        Console.WriteLine(txt);

                        // Redraw the network.
                        networkPictureBox.Refresh();
                    }
                }
            }
            else if (Mode == Modes.LabelSettingTree)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Build a label setting shortest path tree.
                    float cost = TheNetwork.FindLabelSettingPathTree(node);
                    string txt = "Total cost: " + cost.ToString();
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.LabelSettingPath)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    if (e.Button == MouseButtons.Left) Node0 = node;
                    else Node1 = node;

                    // See if we have both nodes.
                    if ((Node0 != null) && (Node1 != null))
                    {
                        // Find a path between the nodes.
                        List<NetworkNode> pathNodes;
                        List<NetworkLink> pathLinks;
                        int cost = TheNetwork.FindLabelSettingPath(Node0, Node1,
                            out pathNodes, out pathLinks);

                        string txt = "Path: ";
                        foreach (NetworkNode pathNode in pathNodes)
                            txt += pathNode.Name + " ";
                        txt += "Total cost: " + cost.ToString();
                        toolStripStatusLabel1.Text = txt;
                        Console.WriteLine(txt);

                        // Redraw the network.
                        networkPictureBox.Refresh();
                    }
                }
            }
            else if (Mode == Modes.LabelCorrectingTree)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    // Build a label setting shortest path tree.
                    float cost = TheNetwork.FindLabelCorrectingPathTree(node);
                    string txt = "Total cost: " + cost.ToString();
                    toolStripStatusLabel1.Text = txt;
                    Console.WriteLine(txt);

                    // Redraw the network.
                    networkPictureBox.Refresh();
                }
            }
            else if (Mode == Modes.LabelCorrectingPath)
            {
                // See if there is a node here.
                NetworkNode node = TheNetwork.FindNode(e.Location);
                if (node == null)
                {
                    SystemSounds.Beep.Play();
                }
                else
                {
                    if (e.Button == MouseButtons.Left) Node0 = node;
                    else Node1 = node;

                    // See if we have both nodes.
                    if ((Node0 != null) && (Node1 != null))
                    {
                        // Find a path between the nodes.
                        List<NetworkNode> pathNodes;
                        List<NetworkLink> pathLinks;
                        int cost = TheNetwork.FindLabelCorrectingPath(Node0, Node1,
                            out pathNodes, out pathLinks);

                        string txt = "Path: ";
                        foreach (NetworkNode pathNode in pathNodes)
                            txt += pathNode.Name + " ";
                        txt += "Total cost: " + cost.ToString();
                        toolStripStatusLabel1.Text = txt;
                        Console.WriteLine(txt);

                        // Redraw the network.
                        networkPictureBox.Refresh();
                    }
                }
            }
        }

        // Start a new network.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheNetwork = new Network();
            networkPictureBox.Refresh();
        }

        #region Toolstrip Buttons

        // Clear all toolstrip toggle buttons except the indicated one.
        private void UntoggleButtons(ToolStripButton except)
        {
            // Untoggle the unselected tools.
            foreach (ToolStripButton button in ToggleButtons)
                if (button != except)
                    button.Checked = false;

            // Clear the status label.
            toolStripStatusLabel1.Text = "";
        }

        // Select this tool.
        private void SelectTool(ToolStripButton button, Modes mode, Cursor cursor)
        {
            UntoggleButtons(button);
            if (button.Checked)
            {
                networkPictureBox.Cursor = cursor;
                Mode = mode;
            }
            else
            {
                networkPictureBox.Cursor = Cursors.Default;
                Mode = Modes.None;
            }
        }

        // Toolstrip buttons.
        private void addNodeToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(addNodeToolStripButton, Modes.AddNode, Cursors.Cross);
        }
        private void addLinkToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(addLinkToolStripButton, Modes.AddLink1, AddLinkCursor);
        }
        private void addLink2ToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(addLink2ToolStripButton, Modes.AddLink2, AddLinkCursor);
        }
        private void dfTraverseToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(dfTraverseToolStripButton, Modes.DFTraversal, Cursors.Cross);
        }
        private void bfTraverseToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(bfTraverseToolStripButton, Modes.BFTraversal, Cursors.Cross);
        }
        private void spanningTreeToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(spanningTreeToolStripButton, Modes.SpanningTree, Cursors.Cross);
        }
        private void minimalSpanningTreeToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(minimalSpanningTreeToolStripButton, Modes.MinimalSpanningTree, Cursors.Cross);
        }

        private void connectedComponentsToolStripButton_Click(object sender, EventArgs e)
        {
            // Find the connected components.
            List<List<NetworkNode>> components =
                TheNetwork.GetConnectedComponents();

            // Display the components.
            string txt = "";
            for (int i = 0; i < components.Count; i++)
            {
                List<NetworkNode> component = components[i];
                txt += ". Component " + i + ": ";
                foreach (NetworkNode componentNode in component)
                    txt += " " + componentNode.ToString();
            }
            txt = txt.Substring(2);
            toolStripStatusLabel1.Text = txt;
            Console.WriteLine(txt);

            // Redraw the network.
            networkPictureBox.Refresh();
        }

        private void anyPathToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(anyPathToolStripButton, Modes.AnyPath, Cursors.Cross);
        }

        private void labelSettingTreeToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(labelSettingTreeToolStripButton, Modes.LabelSettingTree, Cursors.Cross);
        }

        private void labelSettingPathToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(labelSettingPathToolStripButton, Modes.LabelSettingPath, Cursors.Cross);
        }

        private void labelCorrectingTreeToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(labelCorrectingTreeToolStripButton, Modes.LabelCorrectingTree, Cursors.Cross);
        }

        private void labelCorrectingPathToolStripButton_Click(object sender, EventArgs e)
        {
            SelectTool(labelCorrectingPathToolStripButton, Modes.LabelCorrectingPath, Cursors.Cross);
        }

        private void allPairsToolStripButton_Click(object sender, EventArgs e)
        {
            // Find all pairs shortest paths.
            int[,] distance;
            int[,] via;
            TheNetwork.FindAllPairsPaths(out distance, out via);

            // Display the arrays.
            Console.WriteLine("Final arrays:");
            Console.WriteLine("distance:");
            Console.WriteLine(ArrayToString(distance, false));
            Console.WriteLine("via:");
            Console.WriteLine(ArrayToString(via, true));

            // Display all of the paths.
            int N = TheNetwork.AllNodes.Count;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    List<NetworkNode> path =
                        TheNetwork.FindAllPairsPath(distance, via, i, j);
                    NetworkNode startNode = TheNetwork.AllNodes[i];
                    NetworkNode endNode = TheNetwork.AllNodes[j];
                    Console.Write(startNode.Name + " --> " + endNode.Name +
                        " [" + distance[i, j] + "] : ");
                    if (path == null) Console.WriteLine("No path");
                    else
                    {
                        foreach (NetworkNode viaNode in path)
                        {
                            Console.Write(viaNode.Name + " ");
                        }
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine("");

            MessageBox.Show("See the Output Window for results.");
        }

        // Return a string representation of the array.
        private string ArrayToString(int[,] array, bool asLetter)
        {
            const int infinity = int.MaxValue / 2;

            string txt = "";
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if ((array[i, j] == infinity) || (array[i, j] < 0))
                        txt += string.Format("{0,2} ", "-");
                    else if (asLetter)
                        txt += string.Format("{0,2} ", (char)('A' + array[i, j]));
                    else
                        txt += string.Format("{0,2} ", array[i, j]);
                }
                txt += Environment.NewLine;
            }
            return txt;
        }

        #endregion

        private void showLinkCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLinkCapacitiesToolStripMenuItem.Checked = false;
            networkPictureBox.Refresh();
        }

        private void showLinkCapacitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLinkCostsToolStripMenuItem.Checked = false;
            networkPictureBox.Refresh();
        }

        private void showNodeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNodeNamesToolStripMenuItem.Checked = false;
            showNodeTextToolStripMenuItem.Checked = true;
            networkPictureBox.Refresh();
        }

        private void showNodeNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNodeNamesToolStripMenuItem.Checked = true;
            showNodeTextToolStripMenuItem.Checked = false;
            networkPictureBox.Refresh();
        }

        // Return a number converted into letters
        // as in A, B, C, ..., AA, AB, AC, ..., BA, BB, BC, ...
        private string NumberToLetters(int number)
        {
            string result = "";
            do
            {
                int letterNum = number % 26;
                number /= 26;
                char ch = (char)('A' + letterNum);
                result = ch + result;
            } while (number > 0);
            return result;
        }

    }
}
