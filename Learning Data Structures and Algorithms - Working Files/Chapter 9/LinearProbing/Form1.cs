using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearProbing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Used to make random values.
        Random Rand = new Random(1111);

        // The hash table.
        private int[] HashTable;
        private int TableSize = 0;
        private int MinValue = 0;
        private int MaxValue = 0;
        private int NumUsed = 0;

        // The special value marking empty spots.
        private const int Empty = int.MinValue;

        // Make the hash table.
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                TableSize = int.Parse(sizeTextBox.Text);
                HashTable = new int[TableSize];
                for (int i = 0; i < TableSize; i++) HashTable[i] = Empty;

                ShowStatistics();

                createGroupBox.Enabled = false;
                loadTableGroupBox.Enabled = true;
                createFindGroupBox.Enabled = true;
                statisticsGroupBox.Enabled = true;
                this.AcceptButton = makeItemsButton;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Make some items.
        private void makeItemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numItems = int.Parse(numItemsTextBox.Text);
                MinValue = int.Parse(minTextBox.Text);
                MaxValue = int.Parse(maxTextBox.Text);
                int itemsAdded = 0;
                int index;
                while (itemsAdded < numItems)
                {
                    try
                    {
                        AddItem(Rand.Next(MinValue, MaxValue + 1), out index);
                        itemsAdded++;
                    }
                    catch (ArgumentException)
                    {
                        // Duplicate value. Try again.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ShowStatistics();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int probes;
            try
            {
                int key = int.Parse(itemTextBox.Text);
                int index;
                probes = AddItem(key, out index);
                MessageBox.Show("Item added. Index: " + index +
                    ", Probes: " + probes);

                ShowStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Find the indicated item.
        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(itemTextBox.Text);
                int index;
                int probes = FindItem(key, out index);
                MessageBox.Show("Index: " + index + ", Probes: " + probes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Display the table's contents and statistics.
        private void ShowStatistics()
        {
            // Display the items in the table.
            string text = "";
            for (int i = 0; i < TableSize; i++)
            {
                if (HashTable[i] == Empty)
                {
                    text += string.Format("{0,4} ", "---");
                }
                else
                {
                    text += string.Format("{0,4} ", HashTable[i]);
                }
                if ((i + 1) % 10 == 0)
                    text = text.Substring(0, text.Length - 1) +
                        Environment.NewLine;
            }
            tableTextBox.Text = text;
            tableTextBox.Select(0, 0);

            // Percent full.
            float pct = 100f * NumUsed / TableSize;
            fillPercentTextBox.Text = pct.ToString("0.00");

            // Check probe sequences.
            int total = 0;
            int index;
            int maxProbes = 0;
            for (int i = MinValue; i <= MaxValue; i++)
            {
                int probes = FindItem(i, out index);
                total += probes;
                if (maxProbes < probes) maxProbes = probes;
            }
            longestTextBox.Text = maxProbes.ToString();
            float ave = total / (MaxValue - MinValue + 1f);
            averageTextBox.Text = ave.ToString("0.00");
        }

        // Add an item to the hash table.
        // Return the length of the probe sequence.
        // Throw an exception if the table is full
        // or the item is already in the table.
        private int AddItem(int key, out int index)
        {
            int probe = key % TableSize;
            int stride = 1;
            for (int probes = 1; probes <= TableSize; probes++)
            {
                // See if this spot is empty.
                if (HashTable[probe] == Empty)
                {
                    // Put the value here.
                    HashTable[probe] = key;
                    index = probe;
                    NumUsed++;
                    return probes;
                }

                // See if the target key is here.
                if (HashTable[probe] == key)
                    throw new ArgumentException(
                        "This key is already in the hash table. Index: " +
                        probe + ", Probes: " + probes);

                // Try a new probe.
                probe = (probe + stride) % TableSize;
            }

            throw new IndexOutOfRangeException("The hash table is full");
        }

        // Find an item in the hash table.
        // Set index to its location or -1 if the item isn't present.
        // Return the length of the probe sequence.
        private int FindItem(int key, out int index)
        {
            int probe = key % TableSize;
            int stride = 1;
            for (int probes = 1; probes <= TableSize; probes++)
            {
                // See if this spot is empty.
                if (HashTable[probe] == Empty)
                {
                    // The key isn't in the table.
                    index = -1;
                    return probes;
                }

                // See if the key is here.
                if (HashTable[probe] == key)
                {
                    // We found the key.
                    index = probe;
                    return probes;
                }

                // Try the next probe.
                probe = (probe + stride) % TableSize;
            }

            // The key isn't in the table (and the table is full).
            index = -1;
            return TableSize;
        }
    }
}
