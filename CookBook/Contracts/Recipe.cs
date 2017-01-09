using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface Recipe : INamed
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Preparation> Preparations { get; }

        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void RemoveProduct(string name);
        void EraseAllProducts();

        void AddPreparation(Preparation preparation);
        void RemovePreparation(Preparation preparation);
        void RemovePreparation(string name);
        void EraseAllPreparations();

        RecipeType RecipeKind { get; }
    }
}
