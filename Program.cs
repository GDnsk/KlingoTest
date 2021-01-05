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
            List<KlingoWord> verbs = KlingoLanguage.GetVerbs(klingoWords);
            List<KlingoWord> firstPersonVerbs = KlingoLanguage.GetFirstPersonVerbs(klingoWords);
            List<KlingoWord> sortedKWords = KlingoSorter.SortAlphabetically(klingoWords);
            string sortedText = KlingoLanguage.KlingoWordsListToText(sortedKWords);

            List<KlingoWord> goodNumbers = KlingoLanguage.GetGoodNumbers(klingoWords);

            int distictsGoodNumbersCount = goodNumbers.Select(x => x.value).Distinct().ToList().Count;

        }
    }
}
