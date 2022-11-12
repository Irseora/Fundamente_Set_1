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
        public static void SwapRestrictionat(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Valorile inversate: {a} {b}");
        }
    }
}