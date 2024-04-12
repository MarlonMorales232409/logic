using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Solutions
{
    public class PaintSquare
    {

        static public void PainSquare(int large)
        {

            for (int i = 1; i <= large; i++)
            {
                string side = new('*', large);

                if(i > 1 && i < large)
                {
                    side = side.Substring(0, 1) + new string(' ', large - 2) + side.Substring(large -1);
                }

                Console.WriteLine(side);

            }

        }

    }
}
