﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void GreaterOrEqualThen(decimal item, decimal min)
        {
            if (item < min)
            {
                throw new ArgumentOutOfRangeException($"Must be equal to or bigger than {min}");
            }
        }

    }
}