
namespace CookBook.Contracts
{
    public interface IPreparation : INamed
    {
        int? Duration { get; }
        string Description { get; }
        bool? Obligatory { get; set; }

    }
}
