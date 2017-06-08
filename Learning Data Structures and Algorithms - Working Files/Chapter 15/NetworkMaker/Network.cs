#define SHOW_ALLPAIRS_PROGRESS

using System;
using System.Collections.Generic;

using System.IO;
using System.Drawing;
using System.Diagnostics;

namespace NetworkMaker
{
    public class Network
    {
        // A list holding all nodes.
        public List<NetworkNode> AllNodes = new List<NetworkNode>();

        // Save the network into the file.
        public void SaveNetwork(string filename)
        {
            // Open the file.
            StreamWriter writer = File.CreateText(filename);

            // Save the number of nodes.
            writer.WriteLine(AllNodes.Count);

            // Renumber the nodes.
            for (int i = 0; i < AllNodes.Count; i++) AllNodes[i].Index = i;

            // Save the node information.
            foreach (NetworkNode node in AllNodes)
            {
                // Save this node's information.
                writer.Write(node.Name + "," +
                    node.Location.X + "," + node.Location.Y);

                // Save information about this node's links.
                foreach (NetworkLink link in node.Links)
                {
                    NetworkNode otherNode;
                    if (link.Nodes[0] == node) otherNode = link.Nodes[1];
                    else otherNode = link.Nodes[0];
                    writer.Write("," + otherNode.Index + "," +
                        link.Cost + "," + link.Capacity);
                }
                writer.WriteLine();
            }

            // Close the file.
            writer.Close();
        }

        // Craete a network from a network file.
        public static Network LoadNetwork(string filename)
        {
            // Make a new network.
            Network network = new Network();

            // Read the data.
            string[] allLines = File.ReadAllLines(filename);

            // Get the number of nodes.
            int numNodes = int.Parse(allLines[0]);

            // Create the nodes.
            for (int i = 0; i < numNodes; i++)
            {
                network.AllNodes.Add(new NetworkNode());
                network.AllNodes[i].Index = i;
            }

            // Read the nodes.
            char[] separators = { ',' };
            for (int i = 1; i < allLines.Length; i++)
            {
                NetworkNode node = network.AllNodes[i - 1];
                string[] nodeFields = allLines[i].Split(separators);

                // Get the node's text and coordinates.
                node.Name = nodeFields[0];
                node.Location = new PointF(
                    int.Parse(nodeFields[1]),
                    int.Parse(nodeFields[2])
                );

                // Get the node's links.
                for (int j = 3; j < nodeFields.Length; j += 3)
                {
                    // Get the next link.
                    NetworkLink link = new NetworkLink();
                    link.Nodes[0] = node;
                    int index = int.Parse(nodeFields[j]);
                    link.Nodes[1] = network.AllNodes[index];
                    link.Cost = int.Parse(nodeFields[j + 1]);
                    link.Capacity = int.Parse(nodeFields[j + 2]);
                    node.Links.Add(link);
                }
            }

            return network;
        }

        // Draw the network.
        public void Draw(bool showNodeText, bool showCosts, bool showCapacities,
            Graphics gr, Font nodeFont, Font linkFont,
            Pen linkPen, Brush linkBrush, Pen nodePen, Brush nodeBrush, Brush textBrush,
            Pen linkPen2, Brush linkBrush2, Pen nodePen2, Brush nodeBrush2, Brush textBrush2)
        {
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                // Draw the non-highlighted links.
                foreach (NetworkNode node in AllNodes)
                    foreach (NetworkLink link in node.Links)
                        if (!link.Visited)
                            link.Draw(showCosts, showCapacities,
                                gr, linkPen, linkBrush, linkFont, sf);

                // Draw the highlighted links.
                foreach (NetworkNode node in AllNodes)
                    foreach (NetworkLink link in node.Links)
                        if (link.Visited)
                            link.Draw(showCosts, showCapacities,
                                gr, linkPen2, linkBrush2, linkFont, sf);

                // Draw the non-highlighted nodes.
                foreach (NetworkNode node in AllNodes)
                    if (!node.Visited)
                        node.Draw(showNodeText, gr, nodePen, nodeBrush, textBrush, nodeFont, sf);

                // Draw the highlighted nodes.
                foreach (NetworkNode node in AllNodes)
                    if (node.Visited)
                        node.Draw(showNodeText, gr, nodePen2, nodeBrush2, textBrush2, nodeFont, sf);
            }
        }

        // Find the node at the given position.
        public NetworkNode FindNode(PointF location)
        {
            foreach (NetworkNode node in AllNodes)
                if (node.IsAt(location)) return node;
            return null;
        }

        // Make a link from node0 to node1.
        public void MakeLink(NetworkNode node0, NetworkNode node1)
        {
            new NetworkLink(node0, node1);
        }

        // Make links from node0 to node1 and node1 to node0.
        public void MakeLinks(NetworkNode node0, NetworkNode node1)
        {
            new NetworkLink(node0, node1);
            new NetworkLink(node1, node0);
        }

        // Reset the network.
        private void ResetNetwork()
        {
            // Deselect all nodes and branches.
            DeselectNodes();
            DeselectBranches();

            // Clear the nodes' Text properties.
            foreach (NetworkNode node in AllNodes)
            {
                node.FromLink = null;
                node.FromNode = null;
                node.Text = null;
            }
        }

        // Deselect all nodes.
        public void DeselectNodes()
        {
            foreach (NetworkNode node in AllNodes)
                node.Visited = false;
        }

        // Deselect all nodes.
        public void DeselectBranches()
        {
            foreach (NetworkNode node in AllNodes)
                foreach (NetworkLink link in node.Links)
                    link.Visited = false;
        }

        // Traverse the network in depth-first order.
        public List<NetworkNode> DepthFirstTraverse(NetworkNode startNode, out bool isConnected)
        {
            // Reset the network.
            ResetNetwork();

            // Keep track of the number of nodes in the traversal.
            int numDone = 0;

            // Push the start node onto the stack.
            Stack<NetworkNode> stack = new Stack<NetworkNode>();
            stack.Push(startNode);

            // Visit the start node.
            List<NetworkNode> traversal = new List<NetworkNode>();
            traversal.Add(startNode);
            startNode.Visited = true;
            startNode.Text = numDone.ToString();
            numDone++;

            // Process the stack until it's empty.
            while (stack.Count > 0)
            {
                // Get the next node from the stack.
                NetworkNode node = stack.Pop();

                // Process the node's links.
                foreach (NetworkLink link in node.Links)
                {
                    NetworkNode toNode = link.Nodes[1];

                    // Only use the link if the destination
                    // node hasn't been visited.
                    if (!toNode.Visited)
                    {
                        // Mark the node as visited.
                        toNode.Visited = true;
                        toNode.Text = numDone.ToString();
                        numDone++;

                        // Add the node to the traversal.
                        traversal.Add(toNode);

                        // Add the link to the traversal.
                        link.Visited = true;

                        // Push the node onto the stack.
                        stack.Push(toNode);
                    }
                }
            }

            // See if the network is connected.
            isConnected = true;
            foreach (NetworkNode node in AllNodes)
                if (!node.Visited)
                {
                    isConnected = false;
                    break;
                }

            return traversal;
        }

        // Traverse the network in breadth-first order.
        public List<NetworkNode> BreadthFirstTraverse(NetworkNode startNode, out bool isConnected)
        {
            // Reset the network.
            ResetNetwork();

            // Keep track of the number of nodes in the traversal.
            int numDone = 0;

            // Add the start node to the queue.
            Queue<NetworkNode> queue = new Queue<NetworkNode>();
            queue.Enqueue(startNode);

            // Visit the start node.
            List<NetworkNode> traversal = new List<NetworkNode>();
            traversal.Add(startNode);
            startNode.Visited = true;
            startNode.Text = numDone.ToString();
            numDone++;

            // Process the queue until it's empty.
            while (queue.Count > 0)
            {
                // Get the next node from the queue.
                NetworkNode node = queue.Dequeue();

                // Process the node's links.
                foreach (NetworkLink link in node.Links)
                {
                    NetworkNode toNode = link.Nodes[1];

                    // Only use the link if the destination
                    // node hasn't been visited.
                    if (!toNode.Visited)
                    {
                        // Mark the node as visited.
                        toNode.Visited = true;
                        toNode.Text = numDone.ToString();
                        numDone++;

                        // Add the node to the traversal.
                        traversal.Add(toNode);

                        // Add the link to the traversal.
                        link.Visited = true;

                        // Add the node onto the queue.
                        queue.Enqueue(toNode);
                    }
                }
            }

            // See if the network is connected.
            isConnected = true;
            foreach (NetworkNode node in AllNodes)
                if (!node.Visited)
                {
                    isConnected = false;
                    break;
                }

            return traversal;
        }

        // Return the network's connected components.
        public List<List<NetworkNode>> GetConnectedComponents()
        {
            // Reset the network.
            ResetNetwork();

            // Keep track of the number of nodes visited.
            int numVisited = 0;

            // Make the result list of lists.
            List<List<NetworkNode>> components = new List<List<NetworkNode>>();

            // Repeat until all nodes are in a connected component.
            while (numVisited < AllNodes.Count)
            {
                // Find a node that hasn't been visited.
                NetworkNode startNode = null;
                foreach (NetworkNode node in AllNodes)
                    if (!node.Visited)
                    {
                        startNode = node;
                        break;
                    }

                // Make sure we found one.
                Debug.Assert(startNode != null);

                // Add the start node to the stack.
                Stack<NetworkNode> stack = new Stack<NetworkNode>();
                stack.Push(startNode);
                startNode.Visited = true;
                numVisited++;

                // Add the node to a new connected component.
                List<NetworkNode> component = new List<NetworkNode>();
                components.Add(component);
                component.Add(startNode);

                // Process the stack until it's empty.
                while (stack.Count > 0)
                {
                    // Get the next node from the stack.
                    NetworkNode node = stack.Pop();

                    // Process the node's links.
                    foreach (NetworkLink link in node.Links)
                    {
                        // Only use the link if the destination
                        // node hasn't been visited.
                        NetworkNode toNode = link.Nodes[1];
                        if (!toNode.Visited)
                        {
                            // Mark the node as visited.
                            toNode.Visited = true;

                            // Mark the link as part of the tree.
                            link.Visited = true;
                            numVisited++;

                            // Add the node to the current connected component.
                            component.Add(toNode);

                            // Push the node onto the stack.
                            stack.Push(toNode);
                        }
                    }
                }
            }

            // Return the components.
            return components;
        }

        // Build a spanning tree. Return its total cost.
        public int MakeSpanningTree(NetworkNode root, out bool isConnected)
        {
            // Reset the network.
            ResetNetwork();

            // The total cost of the links in the spanning tree.
            int totalCost = 0;

            // Push the root node onto the stack.
            Stack<NetworkNode> stack = new Stack<NetworkNode>();
            stack.Push(root);

            // Visit the root node.
            root.Visited = true;

            // Process the stack until it's empty.
            while (stack.Count > 0)
            {
                // Get the next node from the stack.
                NetworkNode node = stack.Pop();

                // Process the node's links.
                foreach (NetworkLink link in node.Links)
                {
                    // Only use the link if the destination
                    // node hasn't been visited.
                    NetworkNode toNode = link.Nodes[1];
                    if (!toNode.Visited)
                    {
                        // Mark the node as visited.
                        toNode.Visited = true;

                        // Record the node that got us here.
                        toNode.FromNode = node;

                        // Mark the link as part of the tree.
                        link.Visited = true;

                        // Push the node onto the stack.
                        stack.Push(toNode);

                        // Add the link's cost to the total cost.
                        totalCost += link.Cost;
                    }
                }
            }

            // See if the network is connected.
            isConnected = true;
            foreach (NetworkNode node in AllNodes)
                if (!node.Visited)
                {
                    isConnected = false;
                    break;
                }

            return totalCost;
        }

        // Build a minimal spanning tree. Return its total cost.
        // When it adds a node to the spanning tree, the algorithm
        // also adds its links that lead outside of the tree to a list.
        // Later it searches that list for a minimal link.
        public int MakeMinimalSpanningTree(NetworkNode root, out bool isConnected)
        {
            // Reset the network.
            ResetNetwork();

            // The total cost of the links in the spanning tree.
            int totalCost = 0;

            // Add the root node's links to the link candidate list.
            List<NetworkLink> candidateLinks = new List<NetworkLink>();
            foreach (NetworkLink link in root.Links)
                candidateLinks.Add(link);

            // Visit the root node.
            root.Visited = true;

            // Process the list until it's empty.
            while (candidateLinks.Count > 0)
            {
                // Find the link with the lowest cost.
                NetworkLink bestLink = candidateLinks[0];
                int bestCost = bestLink.Cost;
                for (int i = 1; i < candidateLinks.Count; i++)
                    if (candidateLinks[i].Cost < bestCost)
                    {
                        // Save this improvement.
                        bestLink = candidateLinks[i];
                        bestCost = bestLink.Cost;
                    }

                // Remove the link from the list.
                candidateLinks.Remove(bestLink);

                // Get the node at the other end of the link.
                NetworkNode toNode = bestLink.Nodes[1];

                // See if the link's node is still unmarked.
                if (!toNode.Visited)
                {
                    // Use the link.
                    bestLink.Visited = true;
                    totalCost += bestLink.Cost;
                    toNode.Visited = true;

                    // Record the node that got us here.
                    toNode.FromNode = bestLink.Nodes[0];

                    // Process toNode's links.
                    foreach (NetworkLink newLink in toNode.Links)
                    {
                        // If the node hasn't been visited,
                        // add the link to the list.
                        if (!newLink.Nodes[1].Visited) candidateLinks.Add(newLink);
                    }
                }
            }

            // See if the network is connected.
            isConnected = true;
            foreach (NetworkNode node in AllNodes)
                if (!node.Visited)
                {
                    isConnected = false;
                    break;
                }

            return totalCost;
        }

        // Find any path between the two nodes. Return the path's total cost.
        public int FindAnyPath(NetworkNode fromNode, NetworkNode toNode,
            out List<NetworkNode> pathNodes, out List<NetworkLink> pathLinks)
        {
            // Make a spanning tree.
            bool isConnected;
            MakeSpanningTree(fromNode, out isConnected);

            // Follow the tree's links back from toNode to fromNode.
            return FindSpanningTreePath(fromNode, toNode, out pathNodes, out pathLinks);
        }

        // Find a shortest path tree rooted at fromNode
        // by using a label setting algorithm.
        // Return the tree's total cost.
        public int FindLabelSettingPathTree(NetworkNode fromNode)
        {
            // Reset the network.
            ResetNetwork();

            // Keep track of the number of nodes in the tree.
            int numDone = 0;

            // Add the start node to the shortest path tree.
            fromNode.Visited = true;
            fromNode.Distance = 0;
            fromNode.Text = numDone.ToString();
            numDone++;

            // Track the tree's total cost.
            int cost = 0;

            // Make the candidate list.
            List<NetworkLink> candidateLinks = new List<NetworkLink>();

            // Add the start node's links to the candidate list.
            foreach (NetworkLink link in fromNode.Links)
                candidateLinks.Add(link);

            // Make a shortest path tree.
            while (candidateLinks.Count > 0)
            {
                // Find the best link.
                NetworkLink bestLink = null;
                int bestCost = int.MaxValue;

                for (int i = candidateLinks.Count - 1; i >= 0; i--)
                {
                    NetworkLink testLink = candidateLinks[i];

                    // See if the link leads outside the tree.
                    if (testLink.Nodes[1].Visited)
                    {
                        // Remove this link.
                        candidateLinks.RemoveAt(i);
                    }
                    else
                    {
                        // See if this link is an improvement.
                        int testCost = testLink.Nodes[0].Distance + testLink.Cost;
                        if (testCost < bestCost)
                        {
                            bestCost = testCost;
                            bestLink = testLink;
                        }
                    }
                }

                // If we found no link, then the candidate
                // list must be empty and we're done.
                if (bestLink == null)
                {
                    Debug.Assert(candidateLinks.Count == 0);
                    break;
                }

                // Use this link.
                // Remove it from the candidate list.
                candidateLinks.Remove(bestLink);

                // Add the node to the tree.
                NetworkNode bestNode = bestLink.Nodes[1];
                bestNode.Distance = bestLink.Nodes[0].Distance + bestLink.Cost;
                bestNode.Visited = true;
                bestLink.Visited = true;
                bestNode.FromNode = bestLink.Nodes[0];
                bestNode.Text = numDone.ToString();
                numDone++;

                // Add the node's links to the tree.
                foreach (NetworkLink newLink in bestNode.Links)
                    if (!newLink.Nodes[1].Visited)
                        candidateLinks.Add(newLink);

                // Add the link's cost to the tree's total cost.
                cost += bestLink.Cost;
            }

            // Return the total cost.
            return cost;
        }

        // Find a shortest path between the two nodes
        // by using a label setting algorithm.
        // Return the path's total cost.
        public int FindLabelSettingPath(NetworkNode fromNode, NetworkNode toNode,
            out List<NetworkNode> pathNodes, out List<NetworkLink> pathLinks)
        {
            // Build a shortest path tree.
            FindLabelSettingPathTree(fromNode);

            // Follow the tree's links back from toNode to fromNode.
            return FindSpanningTreePath(fromNode, toNode, out pathNodes, out pathLinks);
        }

        // Follow a spanning tree's links to find a path from fromNode to toNode.
        public int FindSpanningTreePath(NetworkNode fromNode, NetworkNode toNode,
            out List<NetworkNode> pathNodes, out List<NetworkLink> pathLinks)
        {
            // Follow the tree's links back from toNode to fromNode.
            pathNodes = new List<NetworkNode>();
            pathLinks = new List<NetworkLink>();
            NetworkNode currentNode = toNode;
            while (currentNode != fromNode)
            {
                // Add this node to the path.
                pathNodes.Add(currentNode);

                // Find the previous node.
                NetworkNode prevNode = currentNode.FromNode;

                // Find the link that leads to currentNode.
                NetworkLink prevLink = null;
                foreach (NetworkLink link in prevNode.Links)
                    if (link.Nodes[1] == currentNode)
                    {
                        prevLink = link;
                        break;
                    }

                // Make sure we found the link.
                Debug.Assert(prevLink != null);

                // Add the link to the path.
                pathLinks.Add(prevLink);

                // Move to the next node.
                currentNode = prevNode;
            } // while (currentNode != fromNode)

            // Add the start node.
            pathNodes.Add(fromNode);

            // Reverse the order of the nodes and links.
            pathNodes.Reverse();
            pathLinks.Reverse();

            // Unmark all nodes and links.
            DeselectNodes();
            DeselectBranches();

            // Marks the path's nodes and links.
            foreach (NetworkNode node in pathNodes) node.Visited = true;
            foreach (NetworkLink link in pathLinks) link.Visited = true;

            // Calculate the cost of the path.
            int cost = 0;
            foreach (NetworkLink link in pathLinks) cost += link.Cost;

            // Return the cost.
            return cost;
        }

        // Find a shortest path tree rooted at fromNode
        // by using a label correcting algorithm.
        // Return the tree's total cost.
        public int FindLabelCorrectingPathTree(NetworkNode fromNode)
        {
            // Reset the network.
            ResetNetwork();

            // Set all nodes' distances to infinity and their labels to 0.
            foreach (NetworkNode node in AllNodes)
            {
                node.Distance = int.MaxValue;
                node.Text = "0";
            }

            // Add the start node to the shortest path tree.
            fromNode.Visited = true;
            fromNode.Distance = 0;

            // Make the candidate list.
            Queue<NetworkLink> candidateLinks = new Queue<NetworkLink>();

            // Add the start node's links to the candidate list.
            foreach (NetworkLink link in fromNode.Links)
                candidateLinks.Enqueue(link);

            // Make a shortest path tree.
            while (candidateLinks.Count > 0)
            {
                // Use the first link in the candidate list.
                NetworkLink link = candidateLinks.Dequeue();

                // See if link this improves its destination node's distance.
                int newDistance = link.Nodes[0].Distance + link.Cost;
                NetworkNode toNode = link.Nodes[1];
                if (newDistance < toNode.Distance)
                {
                    // This is an improvement.
                    // Update the node's distance.
                    toNode.Distance = newDistance;

                    // Update the node's FromNode and FromLink.
                    toNode.FromNode = link.Nodes[0];
                    toNode.FromLink = link;

                    // Update the node's label.
                    int numUpdates = int.Parse(toNode.Text);
                    numUpdates++;
                    toNode.Text = numUpdates.ToString();

                    // Add the node's links to the candidate list.
                    foreach (NetworkLink newLink in toNode.Links)
                        candidateLinks.Enqueue(newLink);
                }
            }

            // Set the Visited properties for the visited nodes and links.
            int cost = 0;
            foreach (NetworkNode node in AllNodes)
            {
                node.Visited = true;
                if (node.FromLink != null)
                {
                    node.FromLink.Visited = true;
                    cost += node.FromLink.Cost;
                }
            }

            // Return the total cost.
            return cost;
        }

        // Find a shortest path between the two nodes
        // by using a label correcting algorithm.
        // Return the path's total cost.
        public int FindLabelCorrectingPath(NetworkNode fromNode, NetworkNode toNode,
            out List<NetworkNode> pathNodes, out List<NetworkLink> pathLinks)
        {
            // Build a shortest path tree.
            FindLabelCorrectingPathTree(fromNode);

            // Follow the tree's links back from toNode to fromNode.
            return FindSpanningTreePath(fromNode, toNode, out pathNodes, out pathLinks);
        }

        // Find all pairs shortest paths.
        public void FindAllPairsPaths(out int[,] distance, out int[,] via)
        {
            const int infinity = int.MaxValue / 2;

            // Renumber the nodes.
            for (int i = 0; i < AllNodes.Count; i++) AllNodes[i].Index = i;

            // Create the distance and via arrays.
            int N = AllNodes.Count;

            // Initialize the distance array.
            distance = new int[N, N];
            // Set all distances to infinity.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    distance[i, j] = infinity;
            // The distance from a node to itself is 0.
            for (int i = 0; i < N; i++) distance[i, i] = 0;
            // Set distances for links.
            foreach (NetworkNode node in AllNodes)
                foreach (NetworkLink link in node.Links)
                {
                    int fromNode = link.Nodes[0].Index;
                    int toNode = link.Nodes[1].Index;
                    if (distance[fromNode, toNode] > link.Cost)
                        distance[fromNode, toNode] = link.Cost;
                }

            // Initialize the via array.
            via = new int[N, N];
            // Set via[i, j] = j if there is a link from i to j.
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if (distance[i, j] < infinity) via[i, j] = j;
                    else via[i, j] = -1;
                }

#if SHOW_ALLPAIRS_PROGRESS
            Console.WriteLine("After initialization:");
            Console.WriteLine("distance:");
            Console.WriteLine(ArrayToString(distance, false));
            Console.WriteLine("via:");
            Console.WriteLine(ArrayToString(via, true));
            Console.WriteLine("");
#endif

            // Find improvements.
            checked
            {
                for (int via_node = 0; via_node < N; via_node++)
                {
                    for (int from_node = 0; from_node < N; from_node++)
                    {
                        for (int to_node = 0; to_node < N; to_node++)
                        {
                            int new_dist =
                                distance[from_node, via_node] +
                                distance[via_node, to_node];
                            if (new_dist < distance[from_node, to_node])
                            {
                                // This is an improved path. Update it.
                                distance[from_node, to_node] = new_dist;
                                via[from_node, to_node] = via_node;
                            }
                        } // Next to_node
                    } // Next from_node

#if SHOW_ALLPAIRS_PROGRESS
                    // Display intermediate results.
                    Console.WriteLine("After updating with node " +
                        via_node + " (" + AllNodes[via_node].Name + "):");
                    Console.WriteLine("distance:");
                    Console.WriteLine(ArrayToString(distance, false));
                    Console.WriteLine("via:");
                    Console.WriteLine(ArrayToString(via, true));
                    Console.WriteLine("");
#endif
                } // Next via_node
            } // checked
        }

        // Return an all pairs path.
        public List<NetworkNode> FindAllPairsPath(int[,] distance, int[,] via,
            int startNode, int endNode)
        {
            const int infinity = int.MaxValue / 2;

            // See if there is a path between these nodes.
            if (distance[startNode, endNode] == infinity) return null;

            // Get the via node for this path.
            int viaNode = via[startNode, endNode];

            // Make the list to return.
            List<NetworkNode> path = new List<NetworkNode>();

            // See if there is a direct connection.
            if (viaNode == endNode)
            {
                // There is a direct connection.
                // Return a list that contains only endNode.
                path.Add(AllNodes[endNode]);
            }
            else
            {
                // There is no direct connection.
                // Return startNode --> viaNode plus viaNode --> endNode.
                path.AddRange(FindAllPairsPath(distance, via, startNode, viaNode));
                path.AddRange(FindAllPairsPath(distance, via, viaNode, endNode));
            }

            return path;
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
    }
}
