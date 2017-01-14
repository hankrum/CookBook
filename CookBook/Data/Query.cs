using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Data
{
    public static class Query
    {
        public static Recipes ByProduct(this Recipes collection, string ProductName)
        {
            var query = 
                from recipe in collection.TheRecipes
                where recipe.TheProducts.ProductsList.Any(product=>product.Name==ProductName)    
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static Recipes SortByType(this Recipes collection)
        {
            var query =
                from recipe in collection.TheRecipes
                orderby recipe.RecipeKind
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }
    }
}
