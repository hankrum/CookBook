using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IEditable
    {
        void Add<T>(T item);
        void Remove<T>(T item);
        void Remove<T>(string name);
        void EraseAll<T>();

    }
}
