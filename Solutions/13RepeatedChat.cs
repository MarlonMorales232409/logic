using System.Text.RegularExpressions;

namespace Logica.Solutions
{
    public class RepeatedChat
    {


        static public KeyValuePair<char, int> HowManyTimesRepeated(string phrase)
        {
            Dictionary<char, int> charMapper = [];

            string cleanPhrase = Regex.Replace(phrase.ToLower(), @"[!¡¿?.\-,;|#]", "");

            foreach (char c in cleanPhrase)
            {
                if (charMapper.ContainsKey(c))
                {
                    charMapper[c]++;
                }
                else
                {
                    charMapper[c] = 1;
                }
            }

            return charMapper.OrderByDescending((e) => e.Value).First();

     
        }
    }
}
