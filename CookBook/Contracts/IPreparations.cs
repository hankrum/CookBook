using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IPreparations
    {
        IEnumerable<IPreparation> Preparations { get; }
        void Add(IPreparation preparation);
        void Remove(IPreparation preparation);
        void Remove(string name);
        void EraseAll();

    }
}
