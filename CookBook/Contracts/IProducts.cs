using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IProducts : IRecordable, IEditable
    {
        IEnumerable<IProduct> Products { get; }
    }
}
