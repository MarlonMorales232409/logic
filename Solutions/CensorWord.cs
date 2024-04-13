using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica.Solutions
{
    public class CensorWord
    {
        static public string CensorWords(string? phrase, string? wordToCensor)
        {
            if (phrase == null && wordToCensor == null) return "You cannot read the phrase and the searched word";

            if (phrase == null) return $"You cannot read the phrase.\nSearched Word: {wordToCensor}";

            if(wordToCensor == null) return phrase;

            string regex = @"\b" + Regex.Escape(wordToCensor) + @"\b";

            string censoredPhrase = Regex.Replace(phrase.ToLower(), regex, "[-CENSORED-]");

            return censoredPhrase;
        }

        static public string CensorWords(string? phrase, List<string>? wordsToCensor)
        {
            if (phrase == null && wordsToCensor == null) return "You cannot read the phrase and the searched word";

            if (phrase == null) return $"You cannot read the phrase.\nSearched Words: {wordsToCensor}";

            if (wordsToCensor == null || wordsToCensor.Count == 0) return phrase;

            string result = phrase;

            for (int i = 0; i < wordsToCensor.Count; i++)
            {
                string regex = @"\b" + Regex.Escape(wordsToCensor[i]) + @"\b";
                result = Regex.Replace(result.ToLower(), regex, "[-CENSORED-]");
                
            }

            return result;
        }
    }
}
