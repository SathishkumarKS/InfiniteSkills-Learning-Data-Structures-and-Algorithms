using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    public class LinkedListQueue<T>
    {
        // Because we add at the top and remove
        // at the bottom, it's useful to use sentinels.
        public QueueCell<T> TopSentinel, BottomSentinel;

        // Initialize the sentinels.
        public LinkedListQueue()
        {
            TopSentinel = new QueueCell<T>();
            BottomSentinel = new QueueCell<T>();

            TopSentinel.Next = BottomSentinel;
            BottomSentinel.Prev = TopSentinel;
        }

        // Add an item to the queue.
        public void Enqueue(T value)
        {
            QueueCell<T> newCell = new QueueCell<T>();
            newCell.Value = value;

            newCell.Next = TopSentinel.Next;
            newCell.Next.Prev = newCell;

            TopSentinel.Next = newCell;
            newCell.Prev = TopSentinel;
        }

        // Remove the target item from the linked list.
        private void RemoveCell(QueueCell<T> target)
        {
            // Get the involved cells.
            QueueCell<T> before = target.Prev;
            QueueCell<T> after = target.Next;

            // Reroute around the target cell.
            before.Next = after;
            after.Prev = before;
        }

        // Remove the oldest item from the queue.
        public T Dequeue()
        {
            if (TopSentinel.Next == BottomSentinel) throw new Exception("The queue is empty.");
            QueueCell<T> target = BottomSentinel.Prev;
            RemoveCell(target);
            return target.Value;
        }
    }
}
