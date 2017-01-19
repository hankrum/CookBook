using CookBook.Common;
using CookBook.Contracts;

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
                Validation.IsNull(value);
                Validation.LengthMoreThan(value, 2);
                this.name = value;
            }
        }

        public NamedObject(string name)
        {
            this.Name = name;
        }
    }
}
