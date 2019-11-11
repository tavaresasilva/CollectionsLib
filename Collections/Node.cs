using System;

namespace com.tavaresasilva.MyOwnCollections
{
    public class Node<T>
    {
        public Node<T> Next { get; }
        public Node<T> Previous { get; set; }
        public T Value { get; }

        public Node(T value, Node<T> next = null, Node<T> previous = null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }

}
