using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IProduct : INamed
    {
        decimal? Quantity { get; }
        MeasuringUnit Unit { get; }
        decimal? Price { get; }
        bool Obligatory { get; set; }
    }
}
