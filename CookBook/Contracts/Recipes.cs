using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface Recipes
    {
        IEnumerable<Recipe> Recipes { get; }
        IEnumerable<Preparation> Preparations { get; }

        void AddRecipe(Recipe recipe);
        void RemoveRecipe(Recipe recipe);
        void Remove(string name);
        void EraseAll();
        void SaveToFile();
        void LoadFromFile();
        IEnumerable<Recipe> QueryByProduct(Product product);
        IEnumerable<Recipe> QueryByProduct(string name);
        IEnumerable<Recipe> QueryByName(string Name);
        IEnumerable<Recipe> QueryByType(RecipeType recipeType);
    }
}
