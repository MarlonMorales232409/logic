namespace Logica.Solutions
{
    /// <summary>
    /// Get the multiplication table of a number
    /// </summary>
    class Multiplication01
    {
        public static string GetMultiplicationTable(int number)
        {
            string result = "";

            int counter = 0;
            while (counter <= 10)
            {
                result += $"{number} x {counter} = {number * counter}\n";
                counter++;
            }

            Console.WriteLine("**************************");
            Console.WriteLine($"Tabla del {number}");
            Console.WriteLine("**************************");
            Console.WriteLine(result);
            return result;
        }
    }
}
