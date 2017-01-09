using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface Recipe : INamed
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Preparation> Preparations { get; }

        RecipeType RecipeKind { get; }
    }
}
