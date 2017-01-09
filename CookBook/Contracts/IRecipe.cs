using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IRecipe : INamed
    {
        IProducts Products { get; }
        IPreparations Preparations { get; }

        RecipeType RecipeKind { get; }
    }
}
