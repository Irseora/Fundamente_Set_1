using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 14. Determinati daca un numar n este palindrom.

namespace Rezolvari
{
    class Prob_14
    {
        /// <summary> Determina daca un numar n este palindrom. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Palindrom(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            int auxN = n, oglindit = 0;
            while (auxN > 0)
            {
                oglindit = oglindit * 10 + (auxN % 10);
                auxN /= 10;
            }

            if (n == oglindit)
                Console.WriteLine($"Da, numarul {n} este palindrom.");
            else
                Console.WriteLine($"Nu, numarul {n} nu este palindrom.");
        }
    }
}