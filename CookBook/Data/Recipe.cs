using System;
using System.Text;
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Recipe:");
            result.AppendFormat(
                "Name: {0};  Recipe kind: {1};  Price: {2};  Preparation time: {3};",
                this.Name,
                this.RecipeKind,
                this.CalculatePrice(),
                this.CalculateDuration()).AppendLine();
            result.Append(this.TheProducts.ToString());
            result.Append(this.ThePreparations.ToString()).AppendLine();
            return result.ToString();
        }

        // Method to calculate the combined price of all the products that will be used in the recipe
        public decimal CalculatePrice()
        {
            decimal finalPrice = 0;

            foreach (var item in this.TheProducts.ProductsList)
            {
                finalPrice += (decimal)item.Price;
            }

            return finalPrice;
        }

        // Method to calculate the time needed to prepare the recipe
        public int CalculateDuration()
        {
            int timeNeeded = 0;

            foreach (var item in this.ThePreparations.PreparationList)
            {
                timeNeeded += (int)item.Duration;
            }

            return timeNeeded;
        }

    }
}
