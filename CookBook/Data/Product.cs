using CookBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Common;

namespace CookBook.Data
{
    public class Product : NamedObject, IProduct
    {
        private bool obligatory;
        private decimal? price;
        private decimal? quantity;
        MeasuringUnit unit;

        public bool Obligatory
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
                this.Price = value;
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
    }
}
