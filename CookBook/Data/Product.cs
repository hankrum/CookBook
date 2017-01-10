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
        private decimal price;
        private decimal quantity;
        MeasuringUnit measuringUnit;

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

        public decimal Price
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

        public decimal Quantity
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
                return this.measuringUnit;
            }
            set
            {
                this.measuringUnit = value;
            }
        }
    }
}
