using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CookBook.Contracts
{
    public interface IProduct : INamed
    {
        decimal? Quantity { get; }
        MeasuringUnit Unit { get; }
        decimal? Price { get; }
        bool? Obligatory { get; set; }

        IProduct Builder(XmlNode item, decimal? quantity, MeasuringUnit unit, decimal? price, bool? obligatory);
       
    }
}
