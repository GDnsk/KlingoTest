using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = StringUtils.SplitTextIntoWords(KlingoLanguage.textA, ' ');
            List<KlingoWord> klingoWords = KlingoLanguage.WordInitializer(words);
            List<KlingoWord> prepositions = KlingoLanguage.GetPropositions(klingoWords);
            List<KlingoWord> verbs = KlingoLanguage.GetVerbs(klingoWords);

            Console.WriteLine(verbs.Count);

        }
    }
}
