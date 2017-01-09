using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IProducts : IRecordable
    {
        IEnumerable<IProduct> Products { get; }
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        void RemoveProduct(string name);
        void EraseAll();
    }
}
