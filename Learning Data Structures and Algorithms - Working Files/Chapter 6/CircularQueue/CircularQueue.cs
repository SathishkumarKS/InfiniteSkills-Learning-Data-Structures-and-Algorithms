
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class CircularQueue<T>
    {
        // The array to hold values.
        public T[] Values;

        // The next open position.
        public int Top = 0;

        // The index of the oldest item in the queue.
        public int Bottom = 0;

        // The number if items currently in the queue.
        public int Count = 0;

        // Allocate the Values array.
        public CircularQueue(int size)
        {
            Values = new T[size];
        }

        // Add an item to the queue.
        public void Enqueue(T value)
        {
            if (Count == Values.Length) throw new Exception("The queue is full.");
            Values[Top] = value;
            Top = (Top + 1) % Values.Length;
            Count++;
        }

        // Remove the oldest item from the queue.
        public T Dequeue()
        {
            if (Count == 0) throw new Exception("The queue is empty.");
            T result = Values[Bottom];
            Bottom = (Bottom + 1) % Values.Length;
            Count--;
            return result;
        }
    }
}
