using System;
using System.Collections.Generic;
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

        public bool Contains(T value)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
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

        internal Node<T> GetFirstNodeWithValue(int value)
        {
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

        public LinkedList()
        {
            head = null;
            count = 0;
        }
        
    }
}
