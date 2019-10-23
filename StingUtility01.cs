using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public class StingUtility
    {
        static void Main(string[] args)
        {
            var sentence = "This is a really really really long text that will appear as the non-summarized version";
            var summary = SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", summaryWords) + "...";
            }
        }
    }
}
