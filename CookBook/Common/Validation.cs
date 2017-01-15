using System;

namespace CookBook.Common
{
    public static class Validation
    {
        public static void LengthMoreThan(string item, int length)
        {
            if (item.Length<length)
            {
                throw new ArgumentOutOfRangeException($"Length must be more than {length}");
            }
        }

        public static void GreaterOrEqualThan(decimal? item, decimal min)
        {
            if (item < min)
            {
                throw new ArgumentOutOfRangeException($"Must be equal to or bigger than {min}");
            }
        }

        public static void GreaterThan(int? item, int min)
        {
            if (item <= min)
            {
                throw new ArgumentOutOfRangeException($"Must be equal to or bigger than {min}");
            }
        }

        public static void IsNull(object item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Object cannot be null");
            }
        }

        public static bool IsNotNullAndNotEmpty(this string text)
        {
            return text != null && text != String.Empty;
        }
    }
}
