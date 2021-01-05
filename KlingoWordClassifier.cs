using System;
using System.Collections.Generic;
using System.Text;

namespace KlingoTest
{
    public static class KlingoWordClassifier
    {
        public static bool CheckIfPreposition(string word)
        {
            // Prepositions must have length of 3
            if (StringUtils.CheckWordAgainstRange(word, 3, 3) == false) return false;

            // Prepositions must not end with fooLetters
            if (StringUtils.CheckIfEndsWithListOfChars(word, KlingoLanguage.fooLetters) == true) return false;

            // Prepositions must not have Letter D
            if (word.Contains('d')) return false;

            return true;
        }

        public static bool CheckIfVerb(string word)
        {
            // Verbs must have length of 8 or greater
            if (StringUtils.CheckWordAgainstRange(word, 8, -1) == false) return false;

            // Verbs must end with fooLetters
            if (StringUtils.CheckIfEndsWithListOfChars(word, KlingoLanguage.fooLetters) == false) return false;

            return true;
        }
    }
}
