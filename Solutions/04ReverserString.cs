namespace Logica.Solutions
{

    /// <summary>
    /// Reverse String without use any method
    /// </summary>
    public class ReverserString04
    {
        static public string ReverserString(string word)
        {
            int wordLength = word.Length;
            string reverseWord = "";

            for (int i = wordLength - 1; i >= 0 ; i--)
            {
                reverseWord += word[i].ToString();
            }

            Console.WriteLine($"Original Word -> {word}");
            Console.WriteLine($"Reverse Word -> {reverseWord}");
                
            return reverseWord;
        }
    }
}
