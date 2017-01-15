using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CookBook.Data
{
    public static class Query
    {
        public static Recipes ByName(this Recipes collection, string name)
        {
            var query =
                from recipe in collection.TheRecipes
                where recipe.Name.ToLower() == name.ToLower()
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());

            return result;
        }

        public static Recipes ByProduct(this Recipes collection, string productName)
        {
            var query = 
                from recipe in collection.TheRecipes
                where recipe.TheProducts.ProductsList.Any(product=>product.Name.ToLower()==productName.ToLower())    
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static Recipes ByType(this Recipes collection, string type)
        {
            RecipeType recipeType = (RecipeType)Enum.Parse(typeof(RecipeType), type);
            var query =
                from recipe in collection.TheRecipes
                where recipe.RecipeKind == recipeType
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static Recipes ByPreparationTime(this Recipes collection, string max)
        {
            var query =
                from recipe in collection.TheRecipes
                where recipe.CalculateDuration() <= int.Parse(max)
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static Recipes ByPrice(this Recipes collection, string max)
        {
            var query =
                from recipe in collection.TheRecipes
                where recipe.CalculatePrice() <= decimal.Parse(max)
                select recipe;
            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static Recipes SortByTypeThenbyName(this Recipes collection)
        {
            var query = collection.TheRecipes.OrderBy(x => x.RecipeKind).ThenBy(x => x.Name);

            Recipes result = new Recipes(query.ToList<Recipe>());
            return result;
        }

        public static IEnumerable<String> GetRecipeNames(this Recipes collection)
        {
            var recipeNames =
                from item in collection.SortByTypeThenbyName().TheRecipes
                select item.Name;
            var recipeNamesList = recipeNames.Distinct();
            return recipeNamesList;
        }

        public static IEnumerable<String> GetProductNames(this Products collection)
        {
            var query =
                from product in collection.ProductsList
                select product.Name.ToLower();
            return query;
        }

        public static IEnumerable<String> GetProductNames(this Recipes collection)
        {
            var query = collection.TheRecipes.SelectMany(x => x.TheProducts.GetProductNames());
            query = query.Distinct().OrderBy(x=>x);
            return query;
        }


    }
}
