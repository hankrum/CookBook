using CookBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Data
{
    public class Products 
    {
        private List<Product> products;

        public List<Product> ProductsList
        {
            get
            {
                return this.products;
            }
        }

        public void Add<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void EraseAll<T>()
        {
            throw new NotImplementedException();
        }

        public void LoadFromFile()
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

        public void SaveToFile()
        {
            throw new NotImplementedException();
        }
    }
}
