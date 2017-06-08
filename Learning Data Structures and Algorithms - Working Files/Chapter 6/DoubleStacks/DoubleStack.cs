using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleStacks
{
    public class DoubleStack<T>
    {
        // The stack array.
        public T[] Values;

        // The next empty spots.
        public int NextLeft, NextRight;

        // Allocate the values array.
        public DoubleStack(int size)
        {
            Values = new T[size];
            NextLeft = 0;
            NextRight = size - 1;
        }

        // Push an item onto the left stack.
        public void PushLeft(T value)
        {
            if (NextLeft > NextRight) throw new Exception("The stack is full.");
            Values[NextLeft++] = value;
        }

        // Push an item onto the right stack.
        public void PushRight(T value)
        {
            if (NextLeft > NextRight) throw new Exception("The stack is full.");
            Values[NextRight--] = value;
        }

        // Pop a value off of the top of the left stack.
        public T PopLeft()
        {
            if (NextLeft == 0) throw new Exception("The stack is empty.");
            return Values[--NextLeft];
        }

        // Pop a value off of the top of the right stack.
        public T PopRight()
        {
            if (NextRight == Values.Length - 1) throw new Exception("The stack is empty.");
            return Values[++NextRight];
        }
    }
}
