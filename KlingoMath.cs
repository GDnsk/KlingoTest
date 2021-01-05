using System;
using System.Collections.Generic;
using System.Text;

namespace KlingoTest
{
    public static class KlingoMath
    {
        public static long ToNumber(string value)
        {
            long number = 0;

            for (int i = 0; i < value.Length; i++)
            {
                char letter = value[i];
                int letterValue = KlingoLanguage.alphabet.IndexOf(letter);
                number += (long)Math.Pow(20, i) * letterValue;
            }
            return number;
        }
        public static bool CheckIfIsGoodNumber(long number)
        {
            // Must be equal or grater than 440566
            if (number < 440566) return false;

            // Must be divisible by 3
            if (number % 3 != 0) return false;

            return true;
        }


    }
}
