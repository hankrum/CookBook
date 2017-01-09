using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IRecipes : IRecordable
    {
        IEnumerable<IRecipe> Recipes { get; }

        void Add(IRecipe recipe);
        void Remove(IRecipe recipe);
        void Remove(string name);
        void EraseAll();
        IEnumerable<IRecipe> QueryByProduct(IProduct product);
        IEnumerable<IRecipe> QueryByProduct(string name);
        IEnumerable<IRecipe> QueryByName(string Name);
        IEnumerable<IRecipe> QueryByType(RecipeType recipeType);
    }
}
