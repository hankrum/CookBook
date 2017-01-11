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

        public void LoadFromFile()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecipe> QueryByName(string Name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecipe> QueryByProduct(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecipe> QueryByProduct(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecipe> QueryByType(RecipeType recipeType)
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

        public void SaveToFile()
        {
            throw new NotImplementedException();
        }

        public void LoadFromXML(XmlNode item)
        {
            foreach (XmlNode recipeItem in item.ChildNodes)
            {
                var nextRecipe = Recipe.Builder(recipeItem);
                this.Add(nextRecipe);
            }
        }
    }
}
