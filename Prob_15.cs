using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.

namespace Rezolvari
{
    class Prob_15
    {
        /// <summary> Afiseaza 3 numere date in ordine crescatoare. Date de intrare: 3 numere </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Crescator3(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti 3 numere intregi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);

            int aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > c) { aux = b; b = c; b = aux; }
            Console.WriteLine($"In ordine crescatoare: {a} {b} {c}");
        }
    }
}