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
    public class Product : NamedObject, IProduct
    {
        private bool? obligatory;
        private decimal? price;
        private decimal? quantity;
        MeasuringUnit? unit;

        public bool? Obligatory
        {
            get
            {
                return this.obligatory;
            }

            set
            {
                this.obligatory = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validation.GreaterOrEqualThan(value, 0);
                this.price = value;
            }
        }

        public decimal? Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                Validation.GreaterOrEqualThan(value, 0);
                this.quantity = value;
            }
        }

        public MeasuringUnit? Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                Validation.IsNull(value);
                this.unit = value;
            }
        }

        private Product(string name, MeasuringUnit? unit) : base(name)
        {
            this.Unit = unit;
        }

        //Only for testing purposes
        public Product(string name, bool? obligatory, decimal? price, decimal? quantity, MeasuringUnit? unit) 
            : this(name, unit)
        {
            this.Obligatory = obligatory;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat(
                "{0} {1} {2}", 
                this.Name,
                this.Quantity != null ? $", Quantity: {this.Quantity.ToString()} {this.Unit}, " : GlobalConstants.EmptyString,
                this.Price != null ? $"Price: {this.Price.ToString()}" : GlobalConstants.EmptyString);
            return result.ToString();
        }

        public static Product Factory(XmlNode item = null, 
            string parName = null,
            decimal? parQuantity = null, 
            MeasuringUnit? parUnit = null, 
            decimal? parPrice = null, 
            bool? parObligatory = null)
        {
            string initialName;
            MeasuringUnit? initialUnit;
            if (item == null)
            {
                initialName = parName;
                initialUnit = parUnit;
            }
            else
            {
                initialName = item["Name"].InnerText;
                initialUnit = (MeasuringUnit)Enum.Parse(typeof(MeasuringUnit), item["Unit"].InnerText);
            }
            Product product = new Product(initialName, initialUnit);

            if (item==null)
            {
                product.Price = parPrice;
                product.Unit = parUnit;
                product.Quantity = parQuantity;
            }
            else
            {
                //string name = item["Name"].InnerText;
                //MeasuringUnit xmlUnit = (MeasuringUnit)Enum.Parse(typeof(MeasuringUnit), item["Unit"].InnerText);

                decimal buffer;
                string text = item["Price"].InnerText;
                if (decimal.TryParse(text, out buffer))
                {
                    product.Price = buffer;
                }
                else
                {
                    product.Price = null;
                }
                if (decimal.TryParse(item["Quantity"].InnerText, out buffer))
                {
                    product.Quantity = buffer;
                }
                else
                {
                    product.Quantity = null;
                }
                bool boolBuffer;
                if (bool.TryParse(item["Obligatory"].InnerText, out boolBuffer))
                {
                    product.Obligatory = boolBuffer;
                }
                else
                {
                    product.Obligatory = null;
                }

            }
            return product;
        }
    }
}
