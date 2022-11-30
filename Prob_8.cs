using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
//    Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

namespace Rezolvari
{
    class Prob_8
    {
        /// <summary> Inverseaza valorile variabilelor a si b, fara a folosi alte variabile. Date de intrare: a, b </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void SwapRestrictionat(string indicatie)
        {
            Console.Clear();
            Console.Write($"{indicatie}{Environment.NewLine}");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Introduceti valorile lui a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            a = a + b;
            b = a - b;  // b = a+b-b = a
            a = a - b;  // a = a+b-a = b

            Console.WriteLine($"Valorile inversate: {a} {b}");
        }
    }
}