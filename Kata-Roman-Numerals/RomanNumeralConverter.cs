using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Kata_Roman_Numerals
{
    public class RomanNumeralConverter
    {
        public const int INVALID_ROMAN_NUMBER = 0;

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
            try
            {
                return _romanValuesLookup[romanNumber];
            }
            catch (Exception)
            {
                Console.WriteLine($"Oops roman number not valid - {romanNumber}");                
            }
            return INVALID_ROMAN_NUMBER;
        }
    }
}