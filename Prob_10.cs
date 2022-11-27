using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Test de primalitate: determinati daca un numar n este prim.

namespace Rezolvari
{
    class Prob_10
    {
        /// <summary> Determina daca un numar n este prim. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Primalitate(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            bool prim = true;

            if (n < 2)
                prim = false;
            else if (n == 2)
                prim = true;
            else if (n % 2 == 0)
                prim = false;
            else
                // Daca se gaseste un divizor, n nu este prim
                for (int div = 3; div * div <= n; div += 2)
                    if (n % div == 0)
                        prim = false;

            if (prim) Console.WriteLine($"Da, {n} este prim.");
            else Console.WriteLine($"Nu, {n} nu este prim.");
        }
    }
}