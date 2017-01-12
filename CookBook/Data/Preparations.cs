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
    public class Preparations 
    {
        private List<Preparation> preparationList;

        public List<Preparation> PreparationList
        {
            get
            {
                return this.preparationList;
            }
        }

        public Preparations()
        {
            this.preparationList = new List<Preparation>();
        }

        public void Add(Preparation item)
        {
            Validation.IsNull(item);
            this.preparationList.Add(item);
        }

        public void EraseAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T item)
        {
            throw new NotImplementedException();
        }

        public static Preparations Builder(XmlNode item)
        {
            Preparations result = new Preparations();

            foreach (XmlNode node in item.ChildNodes)
            {
                Preparation pItem = Preparation.Factory(node);
                result.Add(pItem);
            }

            return result;
        }

    }
}
