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
        private Products theProducts;

        public Preparations ThePreparations
        {
            get
            {
                return this.thePreparations;
            }
            private set
            {
                this.thePreparations = value;
            }
        }

        public Products TheProducts
        {
            get
            {
                return this.theProducts;
            }
            private set
            {
                this.theProducts = value;
            }
        }

        public RecipeType RecipeKind
        {
            get; private set;
        }

        private Recipe(string name, RecipeType kind) : base(name)
        {
            this.thePreparations = new Preparations();
            this.theProducts = new Products();
            this.RecipeKind = kind;
        }

        public static Recipe Factory(XmlNode item)
        {
            string initialName = item["Name"].InnerText;
            RecipeType initialKind = (RecipeType)Enum.Parse(typeof(RecipeType), item["RecipeKind"].InnerText);
            Products products = Products.Builder(item["Products"]);
            Preparations preparations = Preparations.Builder(item["Preparations"]);
            Recipe result = new Recipe(initialName, initialKind);
            result.TheProducts = products;
            result.ThePreparations = preparations;

            return result;
        }
    }
}
