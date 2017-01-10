using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    public interface IRecordable
    {
        void SaveToFile();
        void LoadFromFile();
    }
}
