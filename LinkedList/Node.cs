using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node Next;
        public Node Previous;
        public Node()
        {
            data = 0;
            Next = null;
            Previous = null;
        }
        public Node(int data, Node Previous, Node Next)
        {
            this.data = data;
            this.Previous = Previous;
            this.Next = Next;
        }
    }
}
