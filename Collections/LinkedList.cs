using System;
using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Collections.Test")]

namespace com.tavaresasilva.MyOwnCollections
{
    public class LinkedList<T> : IList<T>
    {
        public int count;
        private Node<T> head;
       
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value, head);
           
            if(head != null)
            {
                head.Previous = newNode;
            }

            head = newNode;
            count++;
        }

        public void Add(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            Node<T> currentNode = head;

            if (currentNode.Value.Equals(value))
            {
                head = head.Next;
            }

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {

                }
            }
        }

        public void Remove(Node<T> node)
        {
            throw new NotImplementedException();

        }

        public bool Contains(T value)
        {
            return FindFirst(value) != null;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return head == null;
        }


        internal Node<T> Next(Node<T> node)
        {
            Node<T> currentNode = head;

            while(currentNode != null)
            {
                if (currentNode.Equals(node))
                {
                    return currentNode.Next;
                }

                currentNode = currentNode.Next;

            }

            return null;
            
        }

        internal Node<T> Previous(Node<T> node)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Equals(node))
                {
                    return currentNode.Previous;
                }

                currentNode = currentNode.Next;
            }

            return currentNode;

        }

        internal Node<T> GetFirstNodeWithValue(T value)
        {
            var node = FindFirst(value);

            Node<T> currentNode = head;

            while ( currentNode != null)
            {
                if ( currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public Node<T> FindFirst(T value)
        {
            var currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public Node<T> FindLast(T value)
        {
            throw new NotImplementedException();
        }

        public IList<Node<T>> FindAll(T value)
        {
            var list = new LinkedList<T>();

            var currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    list.Add(currentNode);
                }

                currentNode = currentNode.Next;
            }

            return null;
        }

        public LinkedList()
        {
            head = null;
            count = 0;
        }
        
    }
}
