using CookBook.Common;
using CookBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CookBook.Test
{
    public static class TestXML
    {
        public static void ProductTestSave()
        {
            Product product = new Product("Rice", false, 5, 6, MeasuringUnit.Kg);

            XmlDocument doc = new XmlDocument();
            XmlElement elem = doc.CreateElement("Product");
            XmlElement name = doc.CreateElement("Name");
            XmlText text = doc.CreateTextNode(product.Name);
            name.AppendChild(text);
            elem.AppendChild(name);
            XmlElement price = doc.CreateElement("Price");
            text = doc.CreateTextNode(product.Price.ToString());
            price.AppendChild(text);
            elem.AppendChild(price);
            XmlElement obligatory = doc.CreateElement("Obligatory");
            text = doc.CreateTextNode(product.Obligatory.ToString());
            obligatory.AppendChild(text);
            elem.AppendChild(obligatory);

            doc.AppendChild(elem);

            
            doc.Save("product-test.xml");
        }

        public static void ProductsLoad()
        {
            List<Product> products = new List<Product>();

            XmlDocument doc = new XmlDocument();
            doc.Load("products.xml");
            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                //string name = node["Name"].InnerText;
                //decimal price = decimal.Parse(node["Price"].InnerText);
                //decimal quantity = decimal.Parse(node["Quantity"].InnerText);
                //bool obligatory = bool.Parse(node["Obligatory"].InnerText);
                //MeasuringUnit unit = (MeasuringUnit)Enum.Parse(typeof(MeasuringUnit), node["Unit"].InnerText);
                Product product = Product.Builder(node);
                products.Add(product);
                Console.WriteLine(product.ToString());
            }
        }

        public static void PreparationsLoad()
        {
            List<Preparation> preparations = new List<Preparation>();

            XmlDocument doc = new XmlDocument();
            doc.Load("preparations.xml");
            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Preparation preparation = Preparation.Builder(node);
                preparations.Add(preparation);
                Console.WriteLine(preparation.ToString());
            }
        }
    }
}
