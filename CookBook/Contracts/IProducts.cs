using System.Collections.Generic;

namespace CookBook.Contracts
{
    public interface IProducts : IEditable
    {
        IList<IProduct> ProductsList { get; }
    }
}
