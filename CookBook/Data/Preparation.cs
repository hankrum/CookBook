using CookBook.Common;
using CookBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CookBook.Data
{
    public class Preparation : NamedObject, IPreparation
    {
        private string description;
        int duration;
        bool obligatory;

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                Validation.GreaterThan(value, 0);
                this.duration = value;
            }
        }

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

        public Preparation(string name, int duration, bool obligatory) : base(name)
        {
            this.Duration = duration;
            this.Obligatory = obligatory;
        }

        public IPreparation Builder(XmlNode item, int duration, string description, bool obligatory)
        {
            throw new NotImplementedException();
        }
    }
}
