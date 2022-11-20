using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

namespace Rezolvari
{
    class Prob_5
    {
        /// <summary> Afiseaza a k-a cifra de la sfarsitul unui numar n
        /// Date de intrare: k, n </summary>
        public static void CifraK(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti valorile lui n si k: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            int putere = (int)Math.Pow(10, k);
            
            Console.Write($"A {k}-a cifra de la sfarsitul lui {n} este ");
            if (putere > n)
                Console.WriteLine('0');
            else
                Console.WriteLine(n % putere / (putere/10));
        }
    }
}