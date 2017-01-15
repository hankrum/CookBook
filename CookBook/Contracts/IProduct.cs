using CookBook.Common;

namespace CookBook.Contracts
{
    public interface IProduct : INamed
    {
        decimal? Quantity { get; }
        MeasuringUnit? Unit { get; }
        decimal? Price { get; }
        bool? Obligatory { get; set; }
       
    }
}
