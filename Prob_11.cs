using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 11. Afisati in ordine inversa cifrele unui numar n.

namespace Rezolvari
{
    class Prob_11
    {
        /// <summary> Afiseaza in ordine inversa cifrele numarului n. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Oglindit(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Oglinditul lui {n} este ");
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }
    }
}