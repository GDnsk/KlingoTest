using System;
using System.Collections.Generic;
using System.Text;

namespace KlingoTest
{
    public class KlingoWord
    {
        public string value;

        public long numericValue;

        public bool IsPreposition { get; set; }

        public bool IsVerb { get; set; }

        public bool IsFirstPersonVerb { get; set; }
        public bool IsGoodNumber { get; set; }

        public KlingoWord(string word)
        {
            value = StringUtils.RemoveWhiteSpace(word);

            IsPreposition = KlingoWordClassifier.CheckIfPreposition(word);

            IsVerb = KlingoWordClassifier.CheckIfVerb(word);

            IsFirstPersonVerb = KlingoWordClassifier.CheckIfFirstPersonVerb(word);

            numericValue = KlingoMath.ToNumber(word);

            IsGoodNumber = KlingoMath.CheckIfIsGoodNumber(numericValue);
        }


    }
}
