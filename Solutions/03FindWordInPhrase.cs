using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica.Solutions
{
    /// <summary>
    /// Find how many times appear a word into a phrase
    /// </summary>
    internal class FindWordInPhrase03
    {
        public static int FindWordInPhrase1(string phrase, string word)
        {
            int counter = 0;
            string[] words = phrase.Split(' ');

            string regex = @"\b" + Regex.Escape(word) + @"\b";

            foreach (var phraseWord in words)
            {
                if (Regex.Match(phraseWord.ToLower(), regex).Success)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int FindWordInPhrase2(string phrase, string word)
        {
            string pattern = @"[!¡¿?.\-,;|#]";
            
            string cleanPhrase = Regex.Replace(phrase.ToLower(), pattern , "");

            int counter = 0;
            if(cleanPhrase.Contains(word))
            {

                string[] arr = cleanPhrase.Split(' ');
                foreach (var phraseWord in arr)
                {
                    if(phraseWord == word) counter++;
                }
            }

            return counter;
        }
    }
}
