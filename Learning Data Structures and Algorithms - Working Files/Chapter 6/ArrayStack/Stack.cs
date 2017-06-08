using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class Stack<T>
    {
        // The stack array.
        public T[] Values;

        // The next empty spot.
        public int NextSpot = 0;

        // Allocate the values array.
        public Stack(int size)
        {
            Values = new T[size];
        }

        // Push an item onto the stack.
        public void Push(T value)
        {
            if (NextSpot >= Values.Length) throw new Exception("The stack is full.");
            Values[NextSpot++] = value;
        }

        // Pop a value off of the top of the stack.
        public T Pop()
        {
            if (NextSpot == 0) throw new Exception("The stack is empty.");
            return Values[--NextSpot];
        }
    }
}
