﻿using CookBook.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
