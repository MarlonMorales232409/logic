namespace Logica.Solutions
{
    public class RepeatMe
    {
        static public string RepeatString(string strToRepeat, int times)
        {
            string result = "";

            for (int i = 1; i <= times; i++)
            {
                result += strToRepeat;
            }

            Console.WriteLine(result);

            return result;
        }
    }
}
