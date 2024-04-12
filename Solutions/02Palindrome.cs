namespace Logica.Solutions
{
    /// <summary>
    /// Verify if a word is palindrome or not
    /// </summary>
    class Palindrome02
    {
        public static bool IsPalindromeWithChar(string word)
        {
            string rawWord = word.ToLower().Trim();
            char[] list = rawWord.ToCharArray().Reverse().ToArray();

            string reverseWord = new(list);

            return rawWord == reverseWord;
        }
    }

}
