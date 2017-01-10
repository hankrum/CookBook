using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    public interface IRecipes : IRecordable, IEditable
    {
        IEnumerable<IRecipe> Recipes { get; }

        IEnumerable<IRecipe> QueryByProduct(IProduct product);
        IEnumerable<IRecipe> QueryByProduct(string name);
        IEnumerable<IRecipe> QueryByName(string Name);
        IEnumerable<IRecipe> QueryByType(RecipeType recipeType);
    }
}
