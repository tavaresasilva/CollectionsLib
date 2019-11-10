using System;

namespace com.tavaresasilva.MyOwnCollections
{
    public class Node
    {
        public Node Next { get; }
        public Node Previous { get; set; }
        public int Value { get; }

        public Node(int value, Node next = null, Node previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }

}
