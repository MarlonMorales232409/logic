namespace Logica.Solutions
{
    public class Stairs
    {
        static public void PrintStairs(int numberOfStairs)
        {
            string stairFigure = "[-]";
            string stairs = stairFigure;

            for (int i = 0; i < numberOfStairs; i++)
            {
                Console.WriteLine(stairs);
                stairs += stairFigure;
            }
        }
    }
}
