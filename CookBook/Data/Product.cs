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
        MeasuringUnit unit;

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
                Validation.GreaterOrEqualThen(value, 0);
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
                Validation.GreaterOrEqualThen(value, 0);
                this.quantity = value;
            }
        }

        public MeasuringUnit Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value;
            }
        }

        public Product(string name, MeasuringUnit unit) : base(name)
        {
            this.Unit = unit;
        }

        //Only for testing purposes
        public Product(string name, bool? obligatory, decimal? price, decimal? quantity, MeasuringUnit unit) 
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

        public IProduct Builder(XmlNode item)
        {
            string name = item["Name"].InnerText;
            decimal buffer;
            decimal? xmlPrice;
            if (decimal.TryParse(item["Price"].InnerText, out buffer))
            {
                xmlPrice = buffer;
            }
            else
            {
                xmlPrice = null;
            }
            decimal? xmlQuantity;
            if (decimal.TryParse(item["Quantity"].InnerText, out buffer))
            {
                xmlQuantity = buffer;
            }
            else
            {
                xmlQuantity = null;
            }
            bool? xmlObligatory;
            bool boolBuffer;
            if (bool.TryParse(item["Obligatory"].InnerText, out boolBuffer))
            {
                xmlObligatory = boolBuffer;
            }
            else
            {
                xmlObligatory = null;
            }
            MeasuringUnit xmlUnit = (MeasuringUnit)Enum.Parse(typeof(MeasuringUnit), item["Unit"].InnerText);
            Product product = new Product(name, xmlObligatory, xmlPrice, xmlQuantity, unit);
            return product;
        }
    }
}
