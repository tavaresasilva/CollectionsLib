using System;
using System.Collections.Generic;
using System.Text;

namespace com.tavaresasilva.MyOwnCollections
{
    public interface IList
    {
        void Add(int value);
        void Remove(int value);
        bool HasValue(int vale);
        int Count();
        bool IsEmpty();
    }
}
