using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingoTest
{
    public static class StringUtils
    {
        /// <summary>
        /// Split a text into a list of words
        /// </summary>
        /// <param name="text">The text to be splitted</param>
        /// <param name="separator">The character that determines where to split</param>
        /// <returns>List of words</returns>
        public static List<string> SplitTextIntoWords(string text, char separator)
        {
            List<string> words = text.Split(separator).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                // Check if string is really a word
                if (String.IsNullOrWhiteSpace(words[i]))
                {
                    words.RemoveAt(i);
                }
                else
                {
                    words[i] = RemoveWhiteSpace(words[i]);
                }
            }

            return words;
        }


        /// <summary>
        /// Removes whitespaces from string
        /// </summary>
        public static string RemoveWhiteSpace(string word)
        {
            return word.Replace(" ", string.Empty);
        }


        /// <summary>
        /// Check if string meets both min and max length parameters
        /// </summary>
        /// <param name="word">String to check</param>
        /// <param name="min">Minimal length of the word,  if -1 this requirement will not be applied</param>
        /// <param name="max">Maximal length of the word, if -1 this requirement will not be applied</param>
        public static bool CheckWordAgainstRange(string word,int min,int max)
        {
            if (word.Length >= min || min == -1)
            {
                if (word.Length <= max || max == -1)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// Compare a word last Character with a list of char,
        /// </summary>
        /// <param name="word">String to compare</param>
        /// <param name="chars">list of characters to compare</param>
        public static bool CheckIfEndsWithListOfChars(string word, List<char> chars)
        {
            return chars.Contains(word.Last());
        }


    }
}
