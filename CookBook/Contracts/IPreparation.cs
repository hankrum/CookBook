using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CookBook.Contracts
{
    public interface IPreparation : INamed
    {
        int? Duration { get; }
        string Description { get; }
        bool? Obligatory { get; set; }

    }
}
