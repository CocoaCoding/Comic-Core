using System.Collections.Generic;

namespace CCore.Data
{
    interface IRepository <T>
    {
        bool Add(T item);

        void Save();
        
        List <T> GetAll();
    }
}
