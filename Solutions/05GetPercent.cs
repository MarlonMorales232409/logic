namespace Logica.Solutions
{
    /// <summary>
    /// Get the percent that represent a number of a value
    /// </summary>
    public class GetPercent
    {
        static public double  GetPercentFromValue(double partValue, double fullValue)
        {
            /// P/T = %/100
            double percent = (partValue / fullValue) * 100; /// Method 1

            //double percent2 = fullValue * (partValue/100); /// Metod 2

            Console.WriteLine(percent.ToString());
            return percent;
        }
    }
}
