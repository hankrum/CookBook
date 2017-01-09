using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface Products
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void RemoveProduct(string name);
        void EraseAll();
        void SaveToFile();
        void LoadFromFile();
    }
}
