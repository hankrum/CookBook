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
    public class Recipe : NamedObject
    {
        private Preparations thePreparations;

        public Preparations ThePreparations
        {
            get
            {
                return this.thePreparations;
            }
        }

        public IProducts Products
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public RecipeType RecipeKind
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRecipe Builder(XmlNode item, IProducts products, IPreparations preparations, RecipeType recipeKind)
        {
            throw new NotImplementedException();
        }
    }
}
