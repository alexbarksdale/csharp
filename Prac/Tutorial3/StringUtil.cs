using System;
using System.Collections.Generic;

namespace Tutorial3
{
    public class StringUtil
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength) return text;

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength) break;
            }

            return String.Join(" ", summaryWords) + "...";;
        }

    }
}