namespace Logica.Solutions
{
    public class Decending
    {

        public static void DecendingInN(int number, int decenderN)
        {
            string result = string.Empty;

            int currentValue = number;

            for (int i = 0; i <= number ; i++)
            {
                result += $"- nº{currentValue}\n";
                currentValue -= decenderN;

                if (currentValue < 0)
                {
                    result += "---FIN---";
                    break;
                }
            }

            Console.WriteLine(result);
        }

    }
}
