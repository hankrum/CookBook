using CookBook.Common;
using System.Collections.Generic;

namespace CookBook.Contracts
{
    public interface IRecipes :  IEditable
    {
        IEnumerable<IRecipe> Recipes { get; }

        IEnumerable<IRecipe> QueryByProduct(IProduct product);
        IEnumerable<IRecipe> QueryByProduct(string name);
        IEnumerable<IRecipe> QueryByName(string Name);
        IEnumerable<IRecipe> QueryByType(RecipeType recipeType);
    }
}
