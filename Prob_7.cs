using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 7. (Swap) Se dau doua variabile numerice a si b ale caror valori sunt date de intrare. Se cere sa se inverseze valorile lor.

namespace Rezolvari
{
    class Prob_7
    {
        /// <summary> Inverseaza valorile variabilelor a si b. Date de intrare: a, b </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Swap(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti valorile lui a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Valorile inversate: {a} {b}");
        }
    }
}