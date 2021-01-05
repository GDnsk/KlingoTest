using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = StringUtils.SplitTextIntoWords(KlingoLanguage.textB, ' ');
            List<KlingoWord> klingoWords = KlingoLanguage.WordInitializer(words);
            List<KlingoWord> prepositions = KlingoLanguage.GetPropositions(klingoWords);

            Console.WriteLine(prepositions.Count);

        }
    }
}
