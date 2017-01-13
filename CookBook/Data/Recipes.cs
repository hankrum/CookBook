using CookBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Common;
using System.Xml;

namespace CookBook.Data
{
    public class Recipes 
    {
        private List<Recipe> theRecipes;

        public Recipes()
        {
            this.theRecipes = new List<Recipe>();
        }

        public Recipes(List<Recipe> collection)
        {
            this.TheRecipes = collection;
        }

        public List<Recipe> TheRecipes
        {
            get
            {
                return this.theRecipes;
            }
            private set
            {
                this.theRecipes = value;
            }
        }

        public void Add(Recipe item)
        {
            Validation.IsNull(item);
            this.theRecipes.Add(item);
        } 

        public void EraseAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void LoadFromXML(XmlNode item)
        {
            foreach (XmlNode recipeItem in item.ChildNodes)
            {
                var nextRecipe = Recipe.Factory(recipeItem);
                this.Add(nextRecipe);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Recipes:\n");
            foreach (var recipe in this.TheRecipes)
            {
                result.Append(recipe.ToString());
            }
            return result.ToString();
        }
    }
}
