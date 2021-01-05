using System;
using System.Collections.Generic;
using System.Text;

namespace KlingoTest
{
    class KlingoSorter
    {
        static int Compare(string x, string y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (i > y.Length - 1) {
                    return 1;
                };
                if (KlingoLanguage.alphabet.IndexOf(x[i]) < KlingoLanguage.alphabet.IndexOf(y[i]))
                {
                    return -1;
                }
                if (KlingoLanguage.alphabet.IndexOf(x[i]) > KlingoLanguage.alphabet.IndexOf(y[i]))
                {
                    return 1;
                }
                continue;
            }
            return -1;
        }

        public static List<KlingoWord> SortAlphabetically(List<KlingoWord> words)
        {
            words.Sort((x, y) => Compare(x.value, y.value));
            return words;
        }
    }
}
