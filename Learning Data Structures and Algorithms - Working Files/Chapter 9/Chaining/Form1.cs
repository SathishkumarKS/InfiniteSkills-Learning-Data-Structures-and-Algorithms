using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaining
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
        private Cell[] HashTable;
        private int TableSize = 0;
        private int MinValue = 0;
        private int MaxValue = 0;
        private int NumUsed = 0;

        // Make the hash table.
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make the buckets. Make each a sentinel.
                TableSize = int.Parse(sizeTextBox.Text);
                HashTable = new Cell[TableSize];
                for (int i = 0; i < TableSize; i++) HashTable[i] = new Cell();

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
                Cell cell;
                int probes = FindItem(key, out cell);
                if (cell == null)
                    MessageBox.Show("Item not found. Probes: " + probes);
                else
                    MessageBox.Show("Item found. Probes: " + probes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Remove an item.
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int key = int.Parse(itemTextBox.Text);
                int probes = RemoveItem(key);
                MessageBox.Show("Removed item. Probes: " + probes);
                ShowStatistics();
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
                text += ">";
                for (Cell cell = HashTable[i].Next; cell != null; cell = cell.Next)
                {
                    text += string.Format(" {0,4}", cell.Value);
                }
                text += Environment.NewLine;
            }
            tableTextBox.Text = text;
            tableTextBox.Select(0, 0);

            // Keys per bucket.
            float keysPerBucket = NumUsed / TableSize;
            keysPerBucketTextBox.Text = keysPerBucket.ToString("0.00");

            // Check probe sequences.
            int total = 0;
            Cell itemCell;
            int maxProbes = 0;
            for (int i = MinValue; i <= MaxValue; i++)
            {
                int probes = FindItem(i, out itemCell);
                total += probes;
                if (maxProbes < probes) maxProbes = probes;
            }
            longestTextBox.Text = maxProbes.ToString();
            float ave = total / (MaxValue - MinValue + 1f);
            averageTextBox.Text = ave.ToString("0.00");
        }

        // Add an item to the hash table.
        // Return the length of the probe sequence.
        // Index is the bucket number.
        // Throw an exception if the item is already in the table.
        private int AddItem(int key, out int index)
        {
            // Find the key's bucket.
            index = key % TableSize;
            Cell bucket = HashTable[index];

            // Search for the item.
            int probes = 0;
            for (Cell cell = bucket.Next; cell != null; cell = cell.Next)
            {
                probes++;
                if (cell.Value == key)
                    throw new ArgumentException(
                        "This key is already in the hash table. Bucket: " +
                        index);
            }

            // Add the item at the beginning of the list.
            Cell newCell = new Cell(key, bucket.Next);
            bucket.Next = newCell;

            NumUsed++;
            return probes;
        }

        // Find an item in the hash table.
        // Set cell to its cell or null if the item isn't present.
        // Return the length of the probe sequence.
        private int FindItem(int key, out Cell cell)
        {
            // Find the key's bucket.
            int index = key % TableSize;
            Cell bucket = HashTable[index];

            // Search for the item.
            int probes = 0;
            for (Cell testCell = bucket.Next; testCell != null; testCell = testCell.Next)
            {
                probes++;
                if (testCell.Value == key)
                {
                    cell = testCell;
                    return probes;
                }
            }

            // The item is not present.
            cell = null;
            return probes;
        }

        // Remove an item. Return the number of probes required.
        // Throw an exception if the item isn't in the hash table.
        private int RemoveItem(int key)
        {
            // Find the key's bucket.
            int index = key % TableSize;
            Cell bucket = HashTable[index];

            // Find the item.
            int probes = 0;
            for (Cell cell = bucket; cell.Next != null; cell = cell.Next)
            {
                probes++;
                if (cell.Next.Value == key)
                {
                    cell = cell.Next;
                    NumUsed--;
                    return probes;
                }
            }

            // The item is not present.
            throw new ArgumentException(
                "This key is not present in the hash table. Bucket: " +
                index + ", Probes: " + probes);
        }
    }
}
