
namespace CookBook.Contracts
{
    public interface IEditable
    {
        void Add<T>(T item);
        void Remove<T>(T item);
        void Remove<T>(string name);
        void EraseAll<T>();

    }
}
