using System.Collections.Generic;

namespace CookBook.Contracts
{
    public interface IPreparations : IEditable
    {
        IEnumerable<IPreparation> Preparations { get; }

    }
}
