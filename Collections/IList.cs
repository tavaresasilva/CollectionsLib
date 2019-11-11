using System;
using System.Collections.Generic;
using System.Text;

namespace com.tavaresasilva.MyOwnCollections
{
    public interface IList<T>
    {
        void Add(T value);
        void Add(Node<T> node);
        void Remove(T value);
        void Remove(Node<T> node);
        bool Contains(T vale);
        int Count();
        bool IsEmpty();
        void Clear();
        Node<T> FindFirst(T value);
        Node<T> FindLast(T value);
        IList<Node<T>> FindAll(T value);

    }
}
