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
        int? duration;
        bool? obligatory;

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

        public int? Duration
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

        private Preparation(string name, int? duration, bool? obligatory) : base(name)
        {
            this.Duration = duration;
            this.Obligatory = obligatory;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat($"\t{this.Name}, duration: {this.Duration}, description: {this.Description}\n");

            return result.ToString();
        }

        public static Preparation Factory(XmlNode item=null,
            string parName=null,
            int? parDuration=null,
            string parDescription=null, 
            bool? parObligatory=null)
        {
            string initialName;
            int? initialDuration;
            string initialDescription;
            bool? initialObligatory;

            if (item == null)
            {
                initialName = parName;
                initialDuration = parDuration;
                initialDescription = parDescription;
                initialObligatory = parObligatory;
            }
            else
            {
                initialName = item["Name"].InnerText;
                initialDuration = int.Parse(item["Duration"].InnerText);
                //string buffer = ;
                initialDescription = item["Description"].InnerText;
                initialObligatory = bool.Parse(item["Obligatory"].InnerText);
            }

            Preparation preparation = new Preparation(initialName, initialDuration, initialObligatory);
            preparation.Description = initialDescription;

            return preparation;
        }
    }
}
