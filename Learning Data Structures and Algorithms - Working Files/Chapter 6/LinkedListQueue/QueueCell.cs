using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    public class QueueCell<T>
    {
        public T Value;
        public QueueCell<T> Next, Prev;
    }
}
