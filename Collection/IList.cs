using System;
using System.Collections.Generic;
using System.Text;

namespace com.tavaresasilva.MyOwnCollections
{
    public interface IList<T>
    {
        void Add(T value);
        void Remove(T value);
        bool Contains(T vale);
        int Count();
        bool IsEmpty();
        void Clear();
    }
}
