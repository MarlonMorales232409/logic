using Logica.Solutions;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "En este vasto mundo, cada rincón es un lugar único lleno de misterios. Explorar el mundo es sumergirse en una aventura sin fin, donde cada lugar guarda secretos sorprendentes. El mundo es nuestro hogar, un lugar maravilloso lleno de diversidad y belleza. No importa dónde vayas, siempre encontrarás algo nuevo por descubrir en este increíble mundo. Cada cultura, cada paisaje, cada lugar contribuye a la increíble variedad que hace que nuestro mundo sea tan fascinante. Así que sal y explora este maravilloso mundo, porque cada lugar que visites te llevará a una nueva experiencia y te recordará la grandeza de nuestro mundo.";

            string r = CensorWord.CensorWords(phrase, ["mundo", "lugar", "belleza"]);

            Console.WriteLine(r);
            
            Console.WriteLine("\n\n");

            Console.WriteLine(phrase);

            /// Dont delete this line
            Console.ReadLine();
        }
    }
}