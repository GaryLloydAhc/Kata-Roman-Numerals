using System;
using System.Collections.Generic;

namespace Kata_Roman_Numerals
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<string, int> _romanValuesLookup = new Dictionary<string, int>
        {
            {"I",1 },
            {"II", 2 },
            {"III", 3 },
            {"IV", 4 },
            {"V", 5 },
        };

        public int ConvertRomanNumeralToDecimal(string romanNumber)
        {
            return _romanValuesLookup[romanNumber];
        }
    }
}