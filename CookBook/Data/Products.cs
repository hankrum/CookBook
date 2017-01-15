using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CookBook.Data
{
    public class Products 
    {
        private List<Product> products;

        public List<Product> ProductsList
        {
            get
            {
                return this.products;
            }
        }

        public Products()
        {
            this.products = new List<Product>();
        }

        public void Add(Product item)
        {
            Validation.IsNull(item);
            this.products.Add(item);
        }

        public void EraseAll()
        {
            this.products.RemoveAll(x=>true);
        }

        public void Remove<T>(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T item)
        {
            throw new NotImplementedException();
        }

        public static Products Builder(XmlNode item)
        {
            Products result = new Products();

            foreach (XmlNode node in item.ChildNodes)
            {
                Product pItem = Product.Factory(node);
                result.Add(pItem);
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Products:");
            foreach (var product in this.ProductsList)
            {
                result.Append(product.ToString());
            }
            return result.ToString();
        }
    }
}
