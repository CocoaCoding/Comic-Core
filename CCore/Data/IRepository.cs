using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CCore.Data
{
    interface IRepository <T>
    {
        bool Add(T item);

        void Save();

        List<T> GetAll();
    }
}
