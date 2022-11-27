using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.

namespace Rezolvari
{
    class Prob_3
    {
        /// <summary> Determina daca un numar n se divide cu un numar k. Date de intrare: n, k </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void DivizibilK(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti valorile lui n si k: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            if (k == 0)
                Console.WriteLine("Divizia cu 0 nu este permisa.");
            else if (n % k == 0)
                Console.WriteLine($"Da, {n} se divide cu {k}.");
            else
                Console.WriteLine($"Nu, {n} nu se divide cu {k}.");
        }
    }
}