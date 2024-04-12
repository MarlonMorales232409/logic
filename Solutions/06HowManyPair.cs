using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Solutions
{
    /// <summary>
    /// How many numbers pairs are between to number
    /// </summary>
    internal class HowManyPair
    {
        static public int HowManyPairsExist(int min, int max)
        {
            int howManyPair = 0;

            for (int i = min; i <= max; i++)
            {
                bool isPair = i % 2 == 0;

                if(isPair) howManyPair++;
            }

            Console.WriteLine(howManyPair);

            return howManyPair;
        }

        static public int HowManyOddExist(int min, int max)
        {
            int howManyPair = 0;

            for (int i = min; i <= max; i++)
            {
                bool isOdd = i % 2 != 0;

                if (isOdd) howManyPair++;
            }

            Console.WriteLine(howManyPair);

            return howManyPair;
        }

        static public List<int> HowManyPairAndOddExist(int min, int max)
        {
            int howManyPair = 0;
            int howManyOdd = 0;

            for (int i = min; i <= max; i++)
            {
                bool isPair = i % 2 == 0;

                if(isPair)
                {
                    howManyPair++;
                }
                else
                {
                    howManyOdd++;
                }

            }

            Console.WriteLine($"Pair: {howManyPair} / Odd: {howManyOdd}");

            return [howManyPair, howManyOdd];
        }
    }
}
