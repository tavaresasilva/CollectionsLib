using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CollectionsTest")]

namespace MyOwnCollections
{
    public class LinkedList : IList
    {
        public int count;
        private Node head;
       
        public void Add(int value)
        {
            Node newNode = new Node(value, head);
           
            if(head != null)
            {
                head.Previous = newNode;
            }

            head = newNode;
            count++;
        }

        public void Remove(int value)
        {
            Node currentNode = head;

            if (currentNode.Value == value)
            {
                head = head.Next;
            }

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {

                }
            }
        }

        public bool HasValue(int value)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
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


        internal Node Next(Node node)
        {
            Node currentNode = head;

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

        internal Node Previous(Node node)
        {
            Node currentNode = head;

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

        internal Node GetFirstNodeWithValue(int value)
        {
            Node currentNode = head;

            while ( currentNode != null)
            {
                if ( currentNode.Value == value)
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public LinkedList()
        {
            head = null;
            count = 0;
        }
        
    }
}
