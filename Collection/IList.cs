using System;
using System.Collections.Generic;
using System.Text;

namespace com.tavaresasilva.MyOwnCollections
{
    public interface IList
    {
        void Add(int value);
        void Remove(int value);
        bool Contains(int vale);
        int Count();
        bool IsEmpty();
        void Clear();
    }
}
