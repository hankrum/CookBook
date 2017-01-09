using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Contracts
{
    interface IRecipe : INamed
    {
        IProducts Products { get; }
        IEnumerable<IPreparation> Preparations { get; }

        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        void RemoveProduct(string name);
        void EraseAllProducts();

        void AddPreparation(IPreparation preparation);
        void RemovePreparation(IPreparation preparation);
        void RemovePreparation(string name);
        void EraseAllPreparations();

        RecipeType RecipeKind { get; }
    }
}
