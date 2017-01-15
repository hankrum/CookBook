using CookBook.Common;
using System.Xml;

namespace CookBook.Contracts
{
    public interface IRecipe : INamed
    {
        IProducts Products { get; }
        IPreparations Preparations { get; }

        RecipeType RecipeKind { get; }

        IRecipe Builder(XmlNode item, IProducts products, IPreparations preparations, RecipeType recipeKind);
    }
}
