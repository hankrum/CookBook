using CookBook.Common;
using CookBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Data
{
    public abstract class NamedObject : INamed
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validation.LengthMoreThan(value, 2);
                this.name = value;
            }
        }
    }
}
